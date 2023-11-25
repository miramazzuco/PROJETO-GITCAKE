﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gitcake;
using modelo;
using MySql.Data.MySqlClient;
using PdfSharp;//biblioteca gerar pdf
using PdfSharp.Drawing;// para desenho
using PdfSharp.Pdf;// conversao
using modelo;
using controller;
using System.Drawing.Printing;
using Org.BouncyCastle.Asn1.Crmf;
using Google;
using PdfSharp.Pdf.AcroForms;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Controls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Application = System.Net.Mime.MediaTypeNames.Application;

namespace controller
{
    public class pedidocontroller
    {
        bool resultado = false;// verificar o resultado 
        conexao conn = new conexao();// chamo o metodo conexao
        string sql;
        public pedidocontroller()
        {
            conn = new conexao();

        }
        public bool cadastrarpedido(pedidomodelo pedi, int operacao)
        {
            try
            {
                switch (operacao)
                {
                    case 1:// inserir dados


                        sql = "insert into pedido(emissao,cliente,item,statuspedido,entrega,endereco,total)" +
                                                    "values(@emissao,@cliente,@item,@statuspedido,@entrega,@endereco,@total)";
                        break;

                    case 2: // atualizar

                        sql = "update pedido set emissao=@emissao,cliente=@cliente,item=@item,statuspedido=@statuspedido,entrega=@entrega,endereco=@endereco,total=@total where idpedido=@id";
                        break;
                    case 3:
                        sql = "DELETE from pedido where idpedido=@id";
                        break;
                }
                string[] campos = { "@emissao", "@cliente", "@item", "@statuspedido", "@entrega" , "@endereco","@total"};
                object[] valores = { pedi.emissao, pedi.cliente, pedi.item, pedi.entrega, pedi.endereco, pedi.total };
                ultimoidcadastrado = conn.cadastrarpedido(pedi.idped, campos, valores, sql);

                if (conn.cadastrar(pedi.idpedido, campos, valores, sql) >= 1)
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










