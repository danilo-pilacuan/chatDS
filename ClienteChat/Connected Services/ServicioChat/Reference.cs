﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteChat.ServicioChat {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/chatDS.DAL")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string claveUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string numCelularField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string claveUsuario {
            get {
                return this.claveUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.claveUsuarioField, value) != true)) {
                    this.claveUsuarioField = value;
                    this.RaisePropertyChanged("claveUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                if ((this.idUsuarioField.Equals(value) != true)) {
                    this.idUsuarioField = value;
                    this.RaisePropertyChanged("idUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string numCelular {
            get {
                return this.numCelularField;
            }
            set {
                if ((object.ReferenceEquals(this.numCelularField, value) != true)) {
                    this.numCelularField = value;
                    this.RaisePropertyChanged("numCelular");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contacto", Namespace="http://schemas.datacontract.org/2004/07/chatDS.DAL")]
    [System.SerializableAttribute()]
    public partial class Contacto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idContactoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idUsuarioEmisorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idUsuarioReceptorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idContacto {
            get {
                return this.idContactoField;
            }
            set {
                if ((this.idContactoField.Equals(value) != true)) {
                    this.idContactoField = value;
                    this.RaisePropertyChanged("idContacto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idUsuarioEmisor {
            get {
                return this.idUsuarioEmisorField;
            }
            set {
                if ((this.idUsuarioEmisorField.Equals(value) != true)) {
                    this.idUsuarioEmisorField = value;
                    this.RaisePropertyChanged("idUsuarioEmisor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idUsuarioReceptor {
            get {
                return this.idUsuarioReceptorField;
            }
            set {
                if ((this.idUsuarioReceptorField.Equals(value) != true)) {
                    this.idUsuarioReceptorField = value;
                    this.RaisePropertyChanged("idUsuarioReceptor");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Mensaje", Namespace="http://schemas.datacontract.org/2004/07/chatDS.DAL")]
    [System.SerializableAttribute()]
    public partial class Mensaje : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contenidoMensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int estadoMensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idEmisorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idMensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idReceptorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contenidoMensaje {
            get {
                return this.contenidoMensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.contenidoMensajeField, value) != true)) {
                    this.contenidoMensajeField = value;
                    this.RaisePropertyChanged("contenidoMensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int estadoMensaje {
            get {
                return this.estadoMensajeField;
            }
            set {
                if ((this.estadoMensajeField.Equals(value) != true)) {
                    this.estadoMensajeField = value;
                    this.RaisePropertyChanged("estadoMensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((this.fechaField.Equals(value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idEmisor {
            get {
                return this.idEmisorField;
            }
            set {
                if ((this.idEmisorField.Equals(value) != true)) {
                    this.idEmisorField = value;
                    this.RaisePropertyChanged("idEmisor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idMensaje {
            get {
                return this.idMensajeField;
            }
            set {
                if ((this.idMensajeField.Equals(value) != true)) {
                    this.idMensajeField = value;
                    this.RaisePropertyChanged("idMensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idReceptor {
            get {
                return this.idReceptorField;
            }
            set {
                if ((this.idReceptorField.Equals(value) != true)) {
                    this.idReceptorField = value;
                    this.RaisePropertyChanged("idReceptor");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioChat.IChatService")]
    public interface IChatService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/crearUsuario", ReplyAction="http://tempuri.org/IChatService/crearUsuarioResponse")]
        int crearUsuario(string numCelular, string claveUsuario, string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/crearUsuario", ReplyAction="http://tempuri.org/IChatService/crearUsuarioResponse")]
        System.Threading.Tasks.Task<int> crearUsuarioAsync(string numCelular, string claveUsuario, string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerUsuarios", ReplyAction="http://tempuri.org/IChatService/obtenerUsuariosResponse")]
        ClienteChat.ServicioChat.Usuario[] obtenerUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerUsuarios", ReplyAction="http://tempuri.org/IChatService/obtenerUsuariosResponse")]
        System.Threading.Tasks.Task<ClienteChat.ServicioChat.Usuario[]> obtenerUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/iniciarSesion", ReplyAction="http://tempuri.org/IChatService/iniciarSesionResponse")]
        ClienteChat.ServicioChat.Usuario iniciarSesion(string numCelular, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/iniciarSesion", ReplyAction="http://tempuri.org/IChatService/iniciarSesionResponse")]
        System.Threading.Tasks.Task<ClienteChat.ServicioChat.Usuario> iniciarSesionAsync(string numCelular, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerContactos", ReplyAction="http://tempuri.org/IChatService/obtenerContactosResponse")]
        ClienteChat.ServicioChat.Contacto[] obtenerContactos(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerContactos", ReplyAction="http://tempuri.org/IChatService/obtenerContactosResponse")]
        System.Threading.Tasks.Task<ClienteChat.ServicioChat.Contacto[]> obtenerContactosAsync(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/agregarContacto", ReplyAction="http://tempuri.org/IChatService/agregarContactoResponse")]
        int agregarContacto(int idUsuarioEmisor, string numCelular);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/agregarContacto", ReplyAction="http://tempuri.org/IChatService/agregarContactoResponse")]
        System.Threading.Tasks.Task<int> agregarContactoAsync(int idUsuarioEmisor, string numCelular);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/comprobarMensajes", ReplyAction="http://tempuri.org/IChatService/comprobarMensajesResponse")]
        bool comprobarMensajes(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/comprobarMensajes", ReplyAction="http://tempuri.org/IChatService/comprobarMensajesResponse")]
        System.Threading.Tasks.Task<bool> comprobarMensajesAsync(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerMensajesPorUsuario", ReplyAction="http://tempuri.org/IChatService/obtenerMensajesPorUsuarioResponse")]
        ClienteChat.ServicioChat.Mensaje[] obtenerMensajesPorUsuario(int idEmisor, int idReceptor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerMensajesPorUsuario", ReplyAction="http://tempuri.org/IChatService/obtenerMensajesPorUsuarioResponse")]
        System.Threading.Tasks.Task<ClienteChat.ServicioChat.Mensaje[]> obtenerMensajesPorUsuarioAsync(int idEmisor, int idReceptor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/enviarMensaje", ReplyAction="http://tempuri.org/IChatService/enviarMensajeResponse")]
        int enviarMensaje(int idEmisor, int idReceptor, string contenido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/enviarMensaje", ReplyAction="http://tempuri.org/IChatService/enviarMensajeResponse")]
        System.Threading.Tasks.Task<int> enviarMensajeAsync(int idEmisor, int idReceptor, string contenido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/marcarLeido", ReplyAction="http://tempuri.org/IChatService/marcarLeidoResponse")]
        int marcarLeido(int idMensaje);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/marcarLeido", ReplyAction="http://tempuri.org/IChatService/marcarLeidoResponse")]
        System.Threading.Tasks.Task<int> marcarLeidoAsync(int idMensaje);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerTodosLosMensajes", ReplyAction="http://tempuri.org/IChatService/obtenerTodosLosMensajesResponse")]
        ClienteChat.ServicioChat.Mensaje[] obtenerTodosLosMensajes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerTodosLosMensajes", ReplyAction="http://tempuri.org/IChatService/obtenerTodosLosMensajesResponse")]
        System.Threading.Tasks.Task<ClienteChat.ServicioChat.Mensaje[]> obtenerTodosLosMensajesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerContactosPorUsuario", ReplyAction="http://tempuri.org/IChatService/obtenerContactosPorUsuarioResponse")]
        ClienteChat.ServicioChat.Usuario[] obtenerContactosPorUsuario(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerContactosPorUsuario", ReplyAction="http://tempuri.org/IChatService/obtenerContactosPorUsuarioResponse")]
        System.Threading.Tasks.Task<ClienteChat.ServicioChat.Usuario[]> obtenerContactosPorUsuarioAsync(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerUsuarioPorNombre", ReplyAction="http://tempuri.org/IChatService/obtenerUsuarioPorNombreResponse")]
        ClienteChat.ServicioChat.Usuario obtenerUsuarioPorNombre(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerUsuarioPorNombre", ReplyAction="http://tempuri.org/IChatService/obtenerUsuarioPorNombreResponse")]
        System.Threading.Tasks.Task<ClienteChat.ServicioChat.Usuario> obtenerUsuarioPorNombreAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerMensajesEntreUsuarios", ReplyAction="http://tempuri.org/IChatService/obtenerMensajesEntreUsuariosResponse")]
        ClienteChat.ServicioChat.Mensaje[] obtenerMensajesEntreUsuarios(int idUsuario1, int idUsuario2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/obtenerMensajesEntreUsuarios", ReplyAction="http://tempuri.org/IChatService/obtenerMensajesEntreUsuariosResponse")]
        System.Threading.Tasks.Task<ClienteChat.ServicioChat.Mensaje[]> obtenerMensajesEntreUsuariosAsync(int idUsuario1, int idUsuario2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatServiceChannel : ClienteChat.ServicioChat.IChatService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatServiceClient : System.ServiceModel.ClientBase<ClienteChat.ServicioChat.IChatService>, ClienteChat.ServicioChat.IChatService {
        
        public ChatServiceClient() {
        }
        
        public ChatServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChatServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int crearUsuario(string numCelular, string claveUsuario, string nombre) {
            return base.Channel.crearUsuario(numCelular, claveUsuario, nombre);
        }
        
        public System.Threading.Tasks.Task<int> crearUsuarioAsync(string numCelular, string claveUsuario, string nombre) {
            return base.Channel.crearUsuarioAsync(numCelular, claveUsuario, nombre);
        }
        
        public ClienteChat.ServicioChat.Usuario[] obtenerUsuarios() {
            return base.Channel.obtenerUsuarios();
        }
        
        public System.Threading.Tasks.Task<ClienteChat.ServicioChat.Usuario[]> obtenerUsuariosAsync() {
            return base.Channel.obtenerUsuariosAsync();
        }
        
        public ClienteChat.ServicioChat.Usuario iniciarSesion(string numCelular, string clave) {
            return base.Channel.iniciarSesion(numCelular, clave);
        }
        
        public System.Threading.Tasks.Task<ClienteChat.ServicioChat.Usuario> iniciarSesionAsync(string numCelular, string clave) {
            return base.Channel.iniciarSesionAsync(numCelular, clave);
        }
        
        public ClienteChat.ServicioChat.Contacto[] obtenerContactos(int idUsuario) {
            return base.Channel.obtenerContactos(idUsuario);
        }
        
        public System.Threading.Tasks.Task<ClienteChat.ServicioChat.Contacto[]> obtenerContactosAsync(int idUsuario) {
            return base.Channel.obtenerContactosAsync(idUsuario);
        }
        
        public int agregarContacto(int idUsuarioEmisor, string numCelular) {
            return base.Channel.agregarContacto(idUsuarioEmisor, numCelular);
        }
        
        public System.Threading.Tasks.Task<int> agregarContactoAsync(int idUsuarioEmisor, string numCelular) {
            return base.Channel.agregarContactoAsync(idUsuarioEmisor, numCelular);
        }
        
        public bool comprobarMensajes(int idUsuario) {
            return base.Channel.comprobarMensajes(idUsuario);
        }
        
        public System.Threading.Tasks.Task<bool> comprobarMensajesAsync(int idUsuario) {
            return base.Channel.comprobarMensajesAsync(idUsuario);
        }
        
        public ClienteChat.ServicioChat.Mensaje[] obtenerMensajesPorUsuario(int idEmisor, int idReceptor) {
            return base.Channel.obtenerMensajesPorUsuario(idEmisor, idReceptor);
        }
        
        public System.Threading.Tasks.Task<ClienteChat.ServicioChat.Mensaje[]> obtenerMensajesPorUsuarioAsync(int idEmisor, int idReceptor) {
            return base.Channel.obtenerMensajesPorUsuarioAsync(idEmisor, idReceptor);
        }
        
        public int enviarMensaje(int idEmisor, int idReceptor, string contenido) {
            return base.Channel.enviarMensaje(idEmisor, idReceptor, contenido);
        }
        
        public System.Threading.Tasks.Task<int> enviarMensajeAsync(int idEmisor, int idReceptor, string contenido) {
            return base.Channel.enviarMensajeAsync(idEmisor, idReceptor, contenido);
        }
        
        public int marcarLeido(int idMensaje) {
            return base.Channel.marcarLeido(idMensaje);
        }
        
        public System.Threading.Tasks.Task<int> marcarLeidoAsync(int idMensaje) {
            return base.Channel.marcarLeidoAsync(idMensaje);
        }
        
        public ClienteChat.ServicioChat.Mensaje[] obtenerTodosLosMensajes() {
            return base.Channel.obtenerTodosLosMensajes();
        }
        
        public System.Threading.Tasks.Task<ClienteChat.ServicioChat.Mensaje[]> obtenerTodosLosMensajesAsync() {
            return base.Channel.obtenerTodosLosMensajesAsync();
        }
        
        public ClienteChat.ServicioChat.Usuario[] obtenerContactosPorUsuario(int idUsuario) {
            return base.Channel.obtenerContactosPorUsuario(idUsuario);
        }
        
        public System.Threading.Tasks.Task<ClienteChat.ServicioChat.Usuario[]> obtenerContactosPorUsuarioAsync(int idUsuario) {
            return base.Channel.obtenerContactosPorUsuarioAsync(idUsuario);
        }
        
        public ClienteChat.ServicioChat.Usuario obtenerUsuarioPorNombre(string nombre) {
            return base.Channel.obtenerUsuarioPorNombre(nombre);
        }
        
        public System.Threading.Tasks.Task<ClienteChat.ServicioChat.Usuario> obtenerUsuarioPorNombreAsync(string nombre) {
            return base.Channel.obtenerUsuarioPorNombreAsync(nombre);
        }
        
        public ClienteChat.ServicioChat.Mensaje[] obtenerMensajesEntreUsuarios(int idUsuario1, int idUsuario2) {
            return base.Channel.obtenerMensajesEntreUsuarios(idUsuario1, idUsuario2);
        }
        
        public System.Threading.Tasks.Task<ClienteChat.ServicioChat.Mensaje[]> obtenerMensajesEntreUsuariosAsync(int idUsuario1, int idUsuario2) {
            return base.Channel.obtenerMensajesEntreUsuariosAsync(idUsuario1, idUsuario2);
        }
    }
}
