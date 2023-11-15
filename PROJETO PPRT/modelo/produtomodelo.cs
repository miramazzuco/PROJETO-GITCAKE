using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class produtomodelo
    {
        
    
        private int cod_prod;
        private string desc_prod;
        private int qtde_prod;
        private decimal preco_prod;
        //private Boolean perecivel_prod;
        private DateTime data_validade;
        private string foto_prod;
        // contrutor da classe

        public produtomodelo()
        {
            this.cod_prod = 0;
            this.desc_prod = "";
            this.qtde_prod = 0;
            this.preco_prod = 0;

            //this.perecivel_prod = false;
            this.data_validade = DateTime.Now;
            this.foto_prod = "0";
        }
        //metodo de acesso as variaveies
        public int idproduto
        {
            get { return cod_prod; }
            //alterar dados da variavel
            set { cod_prod = value; }
        }
        public string descricao
        {
            get { return desc_prod; }
            set { desc_prod = value; }
        }
        public int quantidade
        {
            get { return qtde_prod; }
            set { qtde_prod = value; }
        }
        public decimal preco
        {
            get { return preco_prod; }
            set { preco_prod = value; }
        }
        /*public bool perecivel
        {
            get { return perecivel_prod; }
            set { perecivel_prod = value; }
        }*/
        public DateTime data_val
        {
            get { return data_validade; }
            set { data_validade = value; }
        }
        public string foto
        {
            get { return foto_prod; }
            set { foto_prod = value; }
        }


    }
}

