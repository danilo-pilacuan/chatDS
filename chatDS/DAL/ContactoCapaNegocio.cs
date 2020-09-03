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

        public List<Contacto> obtenerContactosPorIdUsuario(int idUsuario)
        {
            return db.listaContactos.ToList();
        }

        public int agregarContacto(Contacto nuevoContacto)
        {
            db.listaContactos.Add(nuevoContacto);
            db.SaveChanges();
            return 1;
        }

        /*public string guardarMensaje(Mensaje nuevoMensaje)
        {
            db.listaMensajes.Add(nuevoMensaje);
            db.SaveChanges();
            return "Exito";
        }*/
    }
}