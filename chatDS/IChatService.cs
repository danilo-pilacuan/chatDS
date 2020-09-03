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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IChatService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IChatService
    {
        /*[OperationContract]
        int enviarMensaje(int idEmisor, int idReceptor, string contenido);

        [OperationContract]
        bool comprobarMensajes(int idEmisor);

        [OperationContract]
        List<Mensaje> obtenerMensajes(int idEmisor, int idReceptor, string contenido);

        [OperationContract]
        List<Usuario> obtenerContactos(int idEmisor);*/

        [OperationContract]
        int crearUsuario(string numCelular,string claveUsuario,string nombre);

        [OperationContract]
        List<Usuario> obtenerUsuarios();

        [OperationContract]
        Usuario iniciarSesion(string numCelular, string clave);

        [OperationContract]
        List<Contacto> obtenerContactos(int idUsuario);

        [OperationContract]
        int agregarContacto(int idUsuarioEmisor, string numCelular);

        [OperationContract]
        bool comprobarMensajes(int idUsuario);

        [OperationContract]
        List<Mensaje> obtenerMensajes(int idUsuario,int idEmisor);

        [OperationContract]
        int enviarMensaje(int idEmisor, int idReceptor, string contenido);

        [OperationContract]
        int marcarLeido(int idMensaje);

    }


   
}
