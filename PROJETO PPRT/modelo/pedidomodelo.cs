using Org.BouncyCastle.Math.EC.Multiplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class pedidomodelo
    {
        public int idped;
        public DateTime emissa;
        public string clienteped;
        public List<itemmodelo> iten;
        public string statusped;
        public Boolean entregaped;
        public string enderecoped;
        public decimal totalped;



        public pedidomodelo()
        {
            this.idped = 0;
            this.emissa = DateTime.Now;
            this.clienteped = "";
            this.iten = new List<itemmodelo>();
            this.statusped = "Aguardando";
            this.entregaped = false;
            this.enderecoped = "";
            this.totalped = 0;

        }

        public int idpedido
        {
            get { return idped; }
            set { idped = value; }
        }

        public DateTime emissao
        {
            get { return emissa; }
            set { emissa = value; }
        }

        public string cliente
        {
            get { return clienteped; }
            set { clienteped = value; }
        }

        public List<itemmodelo> item
        {
            get { return iten; }
            set { iten = value; }
        }

        public string statuspedido
        {
            get { return statusped; }
            set { statusped = value; }
        }

        public Boolean entrega
        {
            get { return entregaped; }
            set { entregaped = value; }
        }

        public string endereco
        {
            get { return enderecoped; }
            set { enderecoped = value; }
        }

        public decimal total
        {
            get { return totalped; }
            set { totalped = value; }
        }

    }





}
