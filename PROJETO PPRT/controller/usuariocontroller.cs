using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
//bibliotecas para banco
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Linq.Expressions;
using Org.BouncyCastle.Asn1.Cms;
using System.Xml.Linq;
using gitcake;

namespace controller
{
    public class usuariocontroller
    {
        // criando medoto de cadastrar usuario
        conexao con = new conexao();
        public bool cadastrar(usuariomodelo usuario) // passo o objetodo cadastro como parametro
        {// declaro a variavel da resposta da query
            bool resultado = false;
            string sql = "insert into usuario(nome,senha,perfil,email)values('" + usuario.nome + "','" + usuario.senha + "','" + usuario.perfil + "','" + usuario.email + "')";
            //chamando minha conexao

            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open(); // abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlcon.Close();//fecho a conexao
            return resultado;// retorno o valor
        }
        public DataTable ObterDados(string sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = con.getConexao();
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
        public bool Excluir(int codigo)
        {
            bool resultado = false;
            MySqlConnection sqlcon = con.getConexao();
            string sql = "delete from usuario where idusuario =" + codigo;
            sqlcon.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, sqlcon);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = sql;
            if (mySqlCommand.ExecuteNonQuery() >= 1)
            {
                resultado = true;
            }
            return resultado;
        }

        public bool editar(usuariomodelo us)
        {
            bool resultado = false;
            string sql = "update usuario set nome=@nome, senha=@senha, email=@email, perfil=@perfil where idusuario=@id";
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            //substituindo a variavel @ pelo comando objeto
            command.Parameters.AddWithValue("@nome", us.nome);
            command.Parameters.AddWithValue("@senha", us.senha);
            command.Parameters.AddWithValue("@id", us.idusuario);
            command.Parameters.AddWithValue("@perfil", us.perfil);
            command.Parameters.AddWithValue("@email", us.email);
            if (command.ExecuteNonQuery() >= 1)
            {
                resultado = true;
            }
            sqlcon.Close();
            return resultado;


        }
        //metodo para carregar o usuario

        public usuariomodelo CarregaUsuario(int codigo)
        {
            usuariomodelo us = new usuariomodelo();
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            string sql = "SELECT * from usuario where idusuario=@id";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            cmd.Parameters.AddWithValue("@id", codigo);//substituo o valor
            MySqlDataReader registro = cmd.ExecuteReader();//leia os dados do banco de dados
            if (registro.HasRows)//existe linha de registro
            {
                registro.Read();//leia o resgitro
                //gravando as informaçoes no modelo usuario
                us.nome = registro["nome"].ToString();
                us.senha = registro["senha"].ToString();
                us.idusuario = Convert.ToInt32(registro["idusuario"]);
                us.perfil = Convert.ToInt32(registro["perfil"]);
                us.email = registro["email"].ToString();
            }
            sqlcon.Close();
            return us;

        }
        public int logar(usuariomodelo us)
        {
            try
            {
                int registro = 0; //retorna o numero de registro

                string sql = "SELECT idusuario from usuario where nome=@usuario and senha=@senha";
                MySqlConnection sqlcon = con.getConexao();
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@usuario", us.nome);
                cmd.Parameters.AddWithValue("@senha", us.senha);
                registro = Convert.ToInt32(cmd.ExecuteScalar());

                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
       
    }
}

