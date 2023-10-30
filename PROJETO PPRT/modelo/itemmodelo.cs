using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class itemmodelo
    {
        public int id = 0;
        public int idprod = 0;
        public int qtd = 0;
        public decimal sub = 0;

        public itemmodelo() {

            this.id = 0;
            this.idprod = 0;
            this.qtd = 0;
            this.sub = 0;
        }

        public int iditem
        {
            get { return id; }
            
            set { id = value; }
        }

        public int idproduto
        {
            get { return idprod; }
            set { idprod = value; }
        }

        public int quantidade
        {
            get { return qtd; }
            set { qtd = value; }
        }

        public decimal subtotal
        {
            get { return sub; }
            set { sub = value; }
        }

    }
}
