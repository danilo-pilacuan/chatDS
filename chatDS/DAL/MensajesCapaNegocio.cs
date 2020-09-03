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
        public List<Mensaje> obtenerMensajesPorUsuario(int idUsuario,int idEmisor)
        {
            List<Mensaje> mensajes = new List<Mensaje>();
            foreach(Mensaje iterM in db.listaMensajes.ToList())
            {
                if(iterM.idEmisor==idEmisor && iterM.idReceptor==idUsuario)
                {
                    mensajes.Add(iterM);
                }
            }

            return mensajes;
        }
    }
}