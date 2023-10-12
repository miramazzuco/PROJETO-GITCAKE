using Org.BouncyCastle.Math.EC.Multiplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;


namespace modelo
{
    public class pedidomodelo
    {
        public int idpedido_ped;
        public int idproduto_ped;
        private DateTime emissao_ped;
        public string cliente_ped;
        public List<itemmodelo> itens_ped;
        /*public List<itemmodelo> iditem;
        public List<itemmodelo> produtoitem;
        public List<itemmodelo> quantidadeitem;
        public List<itemmodelo> subtotalitem;*/
        public string status_ped;
        public bool entrega_ped;
        public string endereco_ped;
        public decimal total_ped;



        public pedidomodelo()
        {
            idproduto_ped = 0;
            emissao_ped = DateTime.Now;
            cliente_ped = "";
            status_ped = "";
            entrega_ped = false;
            endereco_ped = "";
            total_ped = 0;
           /* iditem = new List<itemmodelo>();
            produtoitem = new List<itemmodelo>();
            quantidadeitem = new List<itemmodelo>();
            subtotalitem = new List<itemmodelo>();*/
        }

        public int idpedido
        {
            get { return idpedido_ped; }
            //alterar dados da variavel
            set { idpedido_ped = value; }
        }

        public int idprodudo
        {
            get { return idproduto_ped; }
            set { idproduto_ped = value; }
        }
        
        public DateTime emissao
        {
            get { return emissao_ped; }
            set { emissao_ped = value; }
        }

        public string cliente
        {
            get { return cliente_ped; }
            set { cliente_ped = value; }
        }

        public List<itemmodelo> itens
        {
            get { return itens_ped; }
            set { itens_ped = value; }

            
        }

        public string status
        {
            get { return status_ped; }
            set { status_ped = value; }
        }

        public bool entrega
        {
            get { return entrega_ped; }
            set { entrega_ped = value; }
        }

        public string endereco
        {
            get { return endereco_ped; }
            set { endereco_ped = value; }
        }

        public decimal total
        {
            get { return total_ped; }
            set { total_ped = value; }
        }

        //public void Add(List<global::modelo.itemmodelo> list) => throw new NotImplementedException();
    }





}
