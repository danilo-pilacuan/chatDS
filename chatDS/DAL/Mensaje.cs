using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace chatDS.DAL
{
    public class Mensaje
    {
        [Key]
        public int idMensaje { set; get; }
        public int idEmisor { set; get; }
        public int idReceptor { set; get; }
        public string contenidoMensaje { set; get; }
        public int estadoMensaje { get; set; }
        public DateTime fecha { get; set; }
    }
}