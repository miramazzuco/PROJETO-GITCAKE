using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class usuariomodelo
    {
        public int idusuario;
        public string nome;
        public string senha;
        public int perfil;
        public string email;
        public string telefone;

        public usuariomodelo()
        {
            nome = null;
            senha = null;
            perfil = 0;
            email = null;
            telefone = null;
        }

        
    }
}
