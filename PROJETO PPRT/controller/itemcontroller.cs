using gitcake;
using modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
    public class itemcontroller
    {
        conexao con = new conexao();
        public itemmodelo CarregaItem(int iditem)
        {
            itemmodelo it = new itemmodelo();
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
                it.produtoitem = Convert.ToInt32(registro["idproduto"]);
                it.quantidadeitem = Convert.ToInt32(registro["quantidadeitem"]);
                it.subtotalitem = Convert.ToInt32(registro["subtotal"]);
                
            }
            sqlcon.Close();
            return it;

        }
    }
}
