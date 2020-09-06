using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace chatDS.DAL
{

    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }


        public string numCelular { get; set; }
        public string claveUsuario { get; set; }

        public string nombre { get; set; }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}