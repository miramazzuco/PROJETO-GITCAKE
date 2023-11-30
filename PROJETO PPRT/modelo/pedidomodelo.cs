using Org.BouncyCastle.Math.EC.Multiplier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class pedidomodelo
    {
        public int idpedido;
        public DateTime emissao;
        public string cliente;
        public string statuspedido;
        public bool entrega;
        public string endereco;
        public decimal total;



        public pedidomodelo()
        {
            idpedido = 0;
            emissao = DateTime.Now;
            cliente = "";
            statuspedido = "Aguardando";
            entrega = false;
            endereco = "";
            total = 0;
        }

    }





}
