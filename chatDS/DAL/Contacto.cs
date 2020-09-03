using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace chatDS.DAL
{

    public class Contacto
    {
        [Key]
        public int idContacto { get; set; }

        public int idUsuarioEmisor { get; set; }
        public int idUsuarioReceptor { get; set; }
    }
}