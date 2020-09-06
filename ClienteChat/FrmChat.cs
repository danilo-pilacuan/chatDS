using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteChat
{
    public partial class FrmChat : Form
    {
        ServicioChat.ChatServiceClient cliente;
        ServicioChat.Usuario usuario;
        ServicioChat.Usuario receptor;
        List<ServicioChat.Usuario> listaUsuariosContactos;
        public FrmChat()
        {
            InitializeComponent();
        }
        public FrmChat(ServicioChat.ChatServiceClient cliente,ServicioChat.Usuario usuario)
        {
            this.cliente = cliente;
            this.usuario = usuario;
            InitializeComponent();
            llenarLstContactos();
        }
        private void llenarLstContactos()
        {
            listaUsuariosContactos = cliente.obtenerContactosPorUsuario(this.usuario.idUsuario).ToList();
            lstContactos.Items.Clear();
            foreach(ServicioChat.Usuario iterUC in listaUsuariosContactos)
            {
                lstContactos.Items.Add(iterUC.nombre);
            }
        }

        private void FrmChat_Load(object sender, EventArgs e)
        {

        }

        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstContactos.SelectedIndex>=0)
            {
                ServicioChat.Usuario auxU = cliente.obtenerUsuarioPorNombre((string)lstContactos.SelectedItem);
                //MessageBox.Show(auxU.numCelular);
                receptor = auxU;
                llenarLstMensajes(auxU.idUsuario);
                
            }
        }

        private void llenarLstMensajes(int idReceptor)
        {
            lstMensajes.Items.Clear();
            List<ServicioChat.Mensaje> listaMensajes = cliente.obtenerMensajesEntreUsuarios(usuario.idUsuario,idReceptor).ToList();
            Console.WriteLine("idR: " + idReceptor);
            Console.WriteLine("idM: " + usuario.idUsuario);
            //Console.WriteLine(listaMensajes);
            Console.WriteLine("Lista Mensajes");
            foreach(ServicioChat.Mensaje iterM in listaMensajes)
            {
                Console.WriteLine(iterM.idMensaje+" "+iterM.contenidoMensaje+" "+iterM.fecha.ToString()+" E:"+iterM.idEmisor+" R:"+iterM.idReceptor);
                if(iterM.idEmisor==usuario.idUsuario)
                {
                    lstMensajes.Items.Add("[" + usuario.nombre + "] " + iterM.contenidoMensaje);
                }
                else
                {
                    lstMensajes.Items.Add("[" + receptor.nombre + "] " + iterM.contenidoMensaje);
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtMensaje.Text!="")
            {
                string mensaje = txtMensaje.Text;
                txtMensaje.Text = "";
                cliente.enviarMensaje(usuario.idUsuario, receptor.idUsuario, mensaje);
            }

        }

        private void lstMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
