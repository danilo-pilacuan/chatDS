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
        public List<Mensaje> obtenerMensajesPorUsuario(int idEmisor,int idReceptor)
        {
            Console.WriteLine("Emisor:" + idEmisor);
            Console.WriteLine("Receptor:" + idReceptor);
            List<Mensaje> mensajes = new List<Mensaje>();
            foreach(Mensaje iterM in db.listaMensajes.ToList())
            {
                //if((iterM.idEmisor==idEmisor && iterM.idReceptor== idReceptor) || (iterM.idEmisor== idReceptor && iterM.idReceptor== idEmisor))
                //{
                if (iterM.idEmisor == idEmisor && iterM.idReceptor==idReceptor)
                    mensajes.Add(iterM);
                //}
            }

            
            List<Mensaje> mensajesOrd = mensajes.OrderBy(o => o.fecha).ToList();
            return mensajes;
            //return db.listaMensajes.ToList();
        }
        public int marcarMsgLeido(int idMensaje)
        {
            foreach (Mensaje iterM in db.listaMensajes.ToList())
            {
                if (iterM.idMensaje == idMensaje)
                {
                    iterM.estadoMensaje = 2;
                    db.SaveChanges();
                    break;
                }
            }
            return 1;
        }
    }
}