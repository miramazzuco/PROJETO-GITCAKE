using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using controller;
using modelo;
//bibliotecas para banco de dados
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Drawing;
using Org.BouncyCastle.Utilities;

namespace gitcake
{
    // classe de conexão com o bando de dados
    public class conexao
    {
        // atriabutos de conexão
        static private string servidor = "localhost";
        static private string db = "gitcake";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection conn = null;

        Random aleatorio = new Random();
        //strCon caminho de conexao
        static private string Strcon = "server=" + servidor + ";database=" + db +
            ";user=" + usuario + ";password=" + senha;


        // metodo de obter a conexao com o mysql

        public MySqlConnection getConexao()
        {
            //defino a varial conexao instanciando uma nova conexao
            MySqlConnection conexao = new MySqlConnection(Strcon);
            return conexao; // retorno o valor da conexao
        }
        public int cadastrar(int codigo, string[] campos, object[] valores, string sql)
        {
            int i;
            int registro = 0;

            try
            {
                conn = getConexao();//chamo o metodo obter conexao
                conn.Open(); // abro o banco direto
                //preparo o comando sql
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //monto meu paramentros do slq
                for (i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);

                }// se Houver erro
                if (codigo > 0)
                {
                    cmd.Parameters.AddWithValue("@id", codigo);
                }
                registro = cmd.ExecuteNonQuery();

                conn.Close();
                return registro;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public int atualizar(string[] campos, object[] valores, string sql)
        {
            int resgistro = 0;
            return resgistro;
        }

        public DataTable ObterDados(string sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = getConexao();
            conn.Open(); //abre o banco de dados
            //preparo o comando sql
            MySqlCommand sqlCon = new MySqlCommand(sql, conn);
            // tipo de instrução testo
            sqlCon.CommandType = System.Data.CommandType.Text;
            sqlCon.CommandText = sql;
            //ira montar as informacoes da consulta
            MySqlDataAdapter dados = new MySqlDataAdapter(sqlCon);
            dados.Fill(dt); // mosntrar a tabela de dados
            conn.Close(); // fecho a conexao
            return dt;

        }
        public string getMD5Hash(string senha)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(senha);
            Byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));

            }
            return sb.ToString();
        }

        public string recuperaremail(string login)
        {//testar a recuperação
            try
            {
                //criar tabela de dados
                DataTable dt = new DataTable();
                string msg = null;//valida a informação 
                string senhanova;
                bool confirmar;

                if (login == null)//valido o preenchimento
                {
                    msg = "login esta vazio";
                }
                else
                {

                    conn = getConexao();//conecta o BD
                    conn.Open();//abrir o BD
                    //chamo a função obter dados passando sql com o login
                    dt = ObterDados("select * from usuario where nome='" + login + "'");
                    //verefico se achou algum registro
                    if (dt.Rows.Count > 0)
                    {
                        string email = "miramazzuco@outlook.com";
                        string senha = "Mi#2006*";
                        //chamar o acesso ao email
                        SmtpClient cliente = new SmtpClient();
                        //chamo o nome do servidor
                        cliente.Host = "smtp.office365.com";
                        //defino a porta de comunicação
                        cliente.Port = 587;
                        //segurança ssl habilitada
                        cliente.EnableSsl = true;
                        //usar credencial padrao
                        cliente.UseDefaultCredentials = false;
                        //chamo minhas credenciais de acesso ao email
                        cliente.Credentials = new System.Net.NetworkCredential(email, senha);
                        //metodo de rede 
                        cliente.DeliveryMethod = SmtpDeliveryMethod.Network;


                        //preparo a mensagem de email
                        MailMessage mail = new MailMessage();
                        //configura o email de envio
                        mail.Sender = new MailAddress(email, "Sistema GITCAKE");//ocuta o nome do email e by Sistema TDS (o emissor)
                        mail.From = new MailAddress(email, "Recuperar senha");//titulo do email
                        //email do usuario
                        string emailusuario = dt.Rows[0][3].ToString();
                        mail.To.Add(new MailAddress(emailusuario, dt.Rows[0][1].ToString()));
                        mail.Subject = "lembrar senha";
                        //gerar senha aleatoria
                        senhanova = aleatorio.Next(2000).ToString();
                        //chamo o modelo e o controle usuario 

                        usuariomodelo usuariomodelo = new usuariomodelo();
                        usuariocontroller uscontroller = new usuariocontroller();

                        usuariomodelo.senha = senhanova;
                        usuariomodelo.nome = dt.Rows[0][1].ToString();
                        usuariomodelo.email = dt.Rows[0][3].ToString();
                        usuariomodelo.perfil = Convert.ToInt32(dt.Rows[0][5].ToString());
                        usuariomodelo.idusuario = Convert.ToInt32(dt.Rows[0][0].ToString());


                        mail.Body = "Ola " + dt.Rows[0][1].ToString() + "sua senha é: " + senhanova;
                        mail.IsBodyHtml = true;//cria um arquivo html

                       confirmar = uscontroller.editar(usuariomodelo);
                        mail.Priority = MailPriority.High;//prioridade de envio
                        try
                        {
                            if (confirmar)
                            {
                                //enviar email
                                cliente.SendAsync(email, emailusuario, mail.Subject, mail.Body, 1);

                                msg = "e-mail enviado com sucesso " + usuariomodelo.senha;
                            }
                            else
                            {
                                msg = "Não foi possivel atualizar senha";
                            }

                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Erro ao enviar email: " + ex.Message);
                        }
                      


                    }
                    else
                    {
                        msg = "Usuario não localizado";
                    }
                }

                return msg;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:" + ex);
            }

        }
    }
}