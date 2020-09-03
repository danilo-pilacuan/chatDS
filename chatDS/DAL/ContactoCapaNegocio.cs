using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chatDS.DAL
{
    public class ContactoCapaNegocio
    {
        private GestorContexto db = new GestorContexto();

        public List<Contacto> obtenerContactos()
        {
            return db.listaContactos.ToList();
        }
        /*public string guardarMensaje(Mensaje nuevoMensaje)
        {
            db.listaMensajes.Add(nuevoMensaje);
            db.SaveChanges();
            return "Exito";
        }*/
    }
}