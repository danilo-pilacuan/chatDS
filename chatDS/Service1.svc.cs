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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public List<Mensaje> GetMsg()
        {
            MensajesCapaNegocio mcn = new MensajesCapaNegocio();
            Mensaje nuevo = new Mensaje();
            nuevo.idEmisor = 1;
            nuevo.idReceptor = 2;
            nuevo.fecha = DateTime.Now;
            nuevo.estadoMensaje = 2;
            nuevo.contenidoMensaje = "Hola";
            mcn.guardarMensaje(nuevo);
            return mcn.obtenerMensajes();
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
