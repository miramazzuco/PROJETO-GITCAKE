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
        private decimal subtotalitem;

        public itemmodelo()
        {
            this.iditem = 0;
            this.idproduto = 0;   
            this.quantidade = 0;
            this.subtotal = 0;
        }

        public int iditem
        {
            get { return id_item; }
            //alterar dados da variavel
            set { id_item = value; }
        }

        public int idproduto
        {
            get { return id_prod; }
            //alterar dados da variavel
            set { id_prod = value; }
        }

        public int quantidade
        {
            get { return qtd_prod; }
            set { qtd_prod = value; }
        }

        public decimal subtotal
        {
            get { return subtotalitem; }
            set { subtotalitem = value; }
        }
    }
}
