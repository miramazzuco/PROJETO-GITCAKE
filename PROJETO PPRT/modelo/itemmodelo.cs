using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class itemmodelo
    {
        private int id_item;
        private int id_prod;
        private int qtd_prod;
        private decimal subtotal;

        public itemmodelo()
        {
            this.iditem = 0;
            this.produtoitem = 0;   
            this.quantidadeitem = 0;
            this.subtotalitem = 0;
        }

        public int iditem
        {
            get { return id_item; }
            //alterar dados da variavel
            set { id_item = value; }
        }

        public int produtoitem
        {
            get { return id_prod; }
            //alterar dados da variavel
            set { id_prod = value; }
        }

        public int quantidadeitem
        {
            get { return qtd_prod; }
            set { qtd_prod = value; }
        }

        public decimal subtotalitem
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
    }
}
