using gitcake;
using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace controller
{
    public class produtocontroller
    {
        bool resultado = false;// verificar o resultado 
        // chamo o metodo conexao
        string sql;
        conexao conn = new conexao();
        public bool cadastrarProduto(produtomodelo prod, int operacao)
        {
            try
            {
                switch (operacao)
                {
                    case 1:// inserir dados


                        sql = "insert into produto(Produto,preco,quantidade,validade,Foto)" +
                                                    "values(@nome,@preco,@qtde,@data,@foto)";
                        break;

                    case 2: // atualizar

                        sql = "update produto set Desc_prod=@nome,Prec_prod=@preco,qtde_prod=@qtde,dat_validade=@data,Foto=@foto where Codpruduto=@id";
                        break;
                    case 3:
                        sql = "DELETE from produto where Codpruduto=@id";
                        break;
                }
                string[] campos = { "@nome", "@preco", "@qtde", "@data", "@foto" };
                object[] valores = { prod.descricao, prod.preco, prod.quantidade, /*prod.perecivel*/ prod.data_val, prod.foto };
                if (conn.cadastrar(prod.codigo, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }
    }
}
