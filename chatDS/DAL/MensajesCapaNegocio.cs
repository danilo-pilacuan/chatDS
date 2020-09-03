using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chatDS.DAL
{
    public class MensajesCapaNegocio
    {
        private GestorContexto db = new GestorContexto();

        public List<Mensaje> obtenerMensajes()
        {
            return db.listaMensajes.ToList();
        }
        public string guardarMensaje(Mensaje nuevoMensaje)
        {
            db.listaMensajes.Add(nuevoMensaje);
            db.SaveChanges();
            return "Exito";
        }
    }
}