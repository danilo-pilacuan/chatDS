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
    // NOTA: Revisar el respositorio
    // NOTA: Revisar interfaz grafica
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ChatService" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ChatService.svc o ChatService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ChatService : IChatService
    {
        public int crearUsuario(string numCelular, string claveUsuario, string nombre)
        {
            UsuarioCapaNegocio ucc = new UsuarioCapaNegocio();
            Usuario nuevoUsuario = new Usuario();
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
            ContactoCapaNegocio ccn = new ContactoCapaNegocio();
            return ccn.obtenerContactos();
        }
        

        public int agregarContacto(int idUsuarioEmisor, string numCelular)
        {
            ContactoCapaNegocio ccn = new ContactoCapaNegocio();
            UsuarioCapaNegocio ucn = new UsuarioCapaNegocio();
            Contacto nuevoContacto = new Contacto();
            nuevoContacto.idUsuarioEmisor = idUsuarioEmisor;
            int idUsuarioReceptor=0;
            foreach (Usuario iterU in ucn.obtenerUsuarios())
            {
                if (iterU.numCelular.Equals(numCelular))
                {
                    idUsuarioReceptor = iterU.idUsuario;
                    break;
                }
            }
            if (idUsuarioReceptor == 0)
                return 0;
            nuevoContacto.idUsuarioReceptor= idUsuarioReceptor;
            ccn.agregarContacto(nuevoContacto);
            return 1;
        }

        public bool comprobarMensajes(int idUsuario)
        {
            //TODO
            MensajesCapaNegocio mcn = new MensajesCapaNegocio();
            List<Mensaje> listaMUsuario = new List<Mensaje>();
            foreach(Mensaje iterM in mcn.obtenerMensajes())
            {
                if(iterM.idReceptor==idUsuario)
                {
                    listaMUsuario.Add(iterM);
                }
            }
            foreach (Mensaje iterM in mcn.obtenerMensajes())
            {
                if(iterM.estadoMensaje==1)
                {
                    return true;
                }
            }
            return false;
        }

        public int obtenerNumeroDeMensajesNoLeidosPorEmisor(int idUsuario1, int idUsuario2)
        {
            int contMensajes = 0;
            MensajesCapaNegocio mcn = new MensajesCapaNegocio();
            List<Mensaje> listaMensajes = mcn.obtenerMensajes();
            List<Mensaje> listaRec = new List<Mensaje>();
            foreach (Mensaje iterM in listaMensajes)
            {
                if (iterM.idEmisor == idUsuario1 && iterM.idReceptor == idUsuario2)
                    listaRec.Add(iterM);
            }

            foreach (Mensaje iterM in listaRec)
            {
                if (iterM.estadoMensaje == 1)
                    contMensajes++;
            }
            return contMensajes;
        }

        public List<Mensaje> obtenerMensajesPorUsuario(int idEmisor, int idReceptor)
        {
            MensajesCapaNegocio mcn = new MensajesCapaNegocio();
            return mcn.obtenerMensajesPorUsuario(idEmisor, idReceptor);
        }

        public int marcarLeido(int idMensaje)
        {
            MensajesCapaNegocio mcn = new MensajesCapaNegocio();
            
            return mcn.marcarMsgLeido(idMensaje);
        }

        public List<Mensaje> obtenerTodosLosMensajes()
        {
            MensajesCapaNegocio mcn = new MensajesCapaNegocio();
            return mcn.obtenerMensajes();
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

        public List<Usuario> obtenerContactosPorUsuario(int idUsuario)
        {
            ContactoCapaNegocio ccn = new ContactoCapaNegocio();
            UsuarioCapaNegocio ucn = new UsuarioCapaNegocio();
            List<Usuario> listaUC = new List<Usuario>();
            foreach (Contacto iterC in ccn.obtenerContactosPorIdUsuario(idUsuario))
            {
                listaUC.Add(ucn.obtenerUsuarioPorId(iterC.idUsuarioReceptor));
            }
            return listaUC;
        }

        public Usuario obtenerUsuarioPorNombre(string nombre)
        {
            UsuarioCapaNegocio ucn = new UsuarioCapaNegocio();
            foreach(Usuario iterU in ucn.obtenerUsuarios())
            {
                if (iterU.nombre.Equals(nombre))
                    return iterU;
            }
            return null;
        }

        public List<Mensaje> obtenerMensajesEntreUsuarios(int idUsuario1, int idUsuario2)
        {
            MensajesCapaNegocio mcn = new MensajesCapaNegocio();
            List<Mensaje> listaMensajes = mcn.obtenerMensajes();
            List<Mensaje> listaRec = new List<Mensaje>();
            foreach(Mensaje iterM in listaMensajes)
            {
                if ((iterM.idEmisor == idUsuario1 && iterM.idReceptor==idUsuario2)|| iterM.idEmisor == idUsuario2 && iterM.idReceptor == idUsuario1)
                    listaRec.Add(iterM);
            }
            List<Mensaje> mensajesOrd = listaRec.OrderBy(o => o.fecha).ToList();
            return mensajesOrd;
        }

    }
}
