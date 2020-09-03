using chatDS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace chatDS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ChatService" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ChatService.svc o ChatService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ChatService : IChatService
    {
        public int crearUsuario(string numCelular, string claveUsuario, string nombre)
        {
            UsuarioCapaNegocio ucc = new UsuarioCapaNegocio();
            Usuario nuevoUsuario = new Usuario();
            //nuevoUsuario.idUsuario = idUsuario;
            nuevoUsuario.numCelular = numCelular;
            nuevoUsuario.claveUsuario = claveUsuario;
            nuevoUsuario.nombre = nombre;
            ucc.crearUsuario(nuevoUsuario);
            return 1;
        }

        public List<Usuario> obtenerUsuarios()
        {
            UsuarioCapaNegocio ucc = new UsuarioCapaNegocio();
            return ucc.obtenerUsuarios();
        }

        public Usuario iniciarSesion(string numCelular, string clave)
        {
            UsuarioCapaNegocio ucc = new UsuarioCapaNegocio();
            List<Usuario> listaUsuarios = ucc.obtenerUsuarios();
            foreach(Usuario iterU in listaUsuarios)
            {
                if(iterU.numCelular.Equals(numCelular) && iterU.claveUsuario.Equals(clave))
                {
                    return iterU;
                }
            }
            return null;
        }

        public List<Contacto> obtenerContactos(int idUsuario)
        {

            return null;
        }

        public int agregarContacto(int idUsuarioEmisor, string numCelular)
        {
            return 0;
        }

        public bool comprobarMensajes(int idUsuario)
        {
            return false;
        }

        public List<Mensaje> obtenerMensajes(int idUsuario, int idEmisor)
        {
            return null;
        }

        public int marcarLeido(int idMensaje)
        {
            return 0;
        }

        public int enviarMensaje(int idEmisor, int idReceptor, string contenido)
        {
            MensajesCapaNegocio mcn = new MensajesCapaNegocio();
            Mensaje nuevoMensaje = new Mensaje();
            nuevoMensaje.idEmisor = idEmisor;
            nuevoMensaje.idReceptor = idReceptor;
            nuevoMensaje.contenidoMensaje = contenido;
            nuevoMensaje.fecha = DateTime.Now;
            nuevoMensaje.estadoMensaje = 1;
            mcn.guardarMensaje(nuevoMensaje);
            return nuevoMensaje.estadoMensaje;
        }

        
    }
}
