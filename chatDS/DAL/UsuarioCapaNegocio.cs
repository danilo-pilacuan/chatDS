using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chatDS.DAL
{
    public class UsuarioCapaNegocio
    {
        private GestorContexto db = new GestorContexto();

        public List<Usuario> obtenerUsuarios()
        {
            return db.listaUsuarios.ToList();
        }
        public string crearUsuario(Usuario nuevoUsuario)
        {
            db.listaUsuarios.Add(nuevoUsuario);
            db.SaveChanges();
            return "Exito";
        }
        /*public string guardarMensaje(Mensaje nuevoMensaje)
        {
            db.listaMensajes.Add(nuevoMensaje);
            db.SaveChanges();
            return "Exito";
        }*/
    }
}