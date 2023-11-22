using Org.BouncyCastle.Math.EC.Multiplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modelo
{
    public class pedidomodelo
    {
        itemmodelo it = new itemmodelo();

        public int idped;
        public DateTime emissa;
        public string clienteped;
        public string itemjson;
        public string statusped;
        public Boolean entregaped;
        public string enderecoped;
        public decimal totalped;



        public pedidomodelo()
        {
            this.idped = 0;
            this.emissa =  DateTime.Now;
            this.clienteped = "";
            this.itemjson = "";
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
       
        public string item 
        {

            get { return itemjson; }
            set { itemjson = value; }
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
