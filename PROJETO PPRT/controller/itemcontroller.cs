using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gitcake;
using modelo;
using MySql.Data.MySqlClient;

namespace controller
{
    public class itemcontroller
    {
        conexao con = new conexao();

        public bool cadastrarItem(itemmodelo item)
        {
            
            bool resultado = false;
            string sql = "insert into item(iditem,idproduto,quantidade,subtotal)values('" + item.iditem + "','" + item.idproduto + "','" + item.quantidade + "','" + item.subtotal + "')";

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

        public bool Excluiritem(int iditem)
        {
            bool resultado = false;
            MySqlConnection sqlcon = con.getConexao();
            string sql = "delete from item where iditem =" + iditem;
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

        public bool limparitem()
        {
            bool resultado = false;
            MySqlConnection sqlcon = con.getConexao();
            string sql = "TRUNCATE TABLE item";
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

        public itemmodelo CarregaItem(int iditem)
        {
            List<itemmodelo> list = new List<itemmodelo>();
            itemmodelo it = new itemmodelo();
            pedidomodelo pd = new pedidomodelo();
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            string sql = "SELECT * from item where iditem=@id";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            cmd.Parameters.AddWithValue("@id", iditem);//substituo o valor
            MySqlDataReader registro = cmd.ExecuteReader();//leia os dados do banco de dados
            if (registro.HasRows)//existe linha de registro
            {
                registro.Read();//leia o resgitro
                //gravando as informaçoes no modelo usuario
                it.iditem = Convert.ToInt32(registro["iditem"]);
                it.idproduto = Convert.ToInt32(registro["idproduto"]);
                it.quantidade = Convert.ToInt32(registro["quantidade"]);
                it.subtotal = Convert.ToDecimal(registro["subtotal"]);
                pd.item = list;
            }
            sqlcon.Close();
            return it;

        }
    }
}
