using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteChat
{
    public class UsuarioLst
    {
        public int idUsuario { get; set; }


        public string numCelular { get; set; }
        public string claveUsuario { get; set; }

        public string nombre { get; set; }

        public int numMensajes { get; set; }

        public override string ToString()
        {
            if (numMensajes == 0)
                return nombre;
            else
                return nombre + " [" + numMensajes.ToString() + "]";

        }
    }
}
