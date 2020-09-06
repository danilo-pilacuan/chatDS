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
        List<UsuarioLst> listaULst;
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
            listaULst = new List<UsuarioLst>();
            foreach (ServicioChat.Usuario iterUC in listaUsuariosContactos)
            {
                UsuarioLst nuevoULst = new UsuarioLst();
                nuevoULst.idUsuario = iterUC.idUsuario;
                nuevoULst.nombre = iterUC.nombre;
                nuevoULst.numCelular = iterUC.numCelular;
                nuevoULst.claveUsuario = iterUC.claveUsuario;
                nuevoULst.numMensajes = cliente.obtenerNumeroDeMensajesNoLeidosPorEmisor(iterUC.idUsuario, usuario.idUsuario);
                lstContactos.Items.Add(nuevoULst);
            }
        }

        private void FrmChat_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstContactos.SelectedIndex>=0)
            {
                ServicioChat.Usuario auxU = cliente.obtenerUsuarioPorNombre(((UsuarioLst)lstContactos.SelectedItem).nombre);
                receptor = auxU;
                llenarLstMensajes(auxU.idUsuario);
                llenarLstContactos();
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
                    if(iterM.estadoMensaje==1)
                        lstMensajes.Items.Add("[" + usuario.nombre + "] " + iterM.contenidoMensaje + ">>Tx");
                    else
                        lstMensajes.Items.Add("[" + usuario.nombre + "] " + iterM.contenidoMensaje + ">>✔");
                }
                else
                {
                    lstMensajes.Items.Add("[" + receptor.nombre + "] " + iterM.contenidoMensaje);
                    cliente.marcarLeido(iterM.idMensaje);
                }
            }
            lstMensajes.TopIndex = lstMensajes.Items.Count - 1;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtMensaje.Text!="")
            {
                string mensaje = txtMensaje.Text;
                txtMensaje.Text = "";
                cliente.enviarMensaje(usuario.idUsuario, receptor.idUsuario, mensaje);
                llenarLstMensajes(receptor.idUsuario);
            }

        }

        private void lstMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            FrmAddContact frmAddContact = new FrmAddContact(cliente,usuario);
            frmAddContact.ShowDialog();
            llenarLstContactos();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(cliente.comprobarMensajes(usuario.idUsuario))
            {
                llenarLstContactos();
                if (receptor != null)
                {
                    if (cliente.obtenerNumeroDeMensajesNoLeidosPorEmisor(receptor.idUsuario, usuario.idUsuario) != 0)
                    {
                        llenarLstMensajes(receptor.idUsuario);
                    }
                }
                else
                {
                    try
                    {
                        ServicioChat.Usuario auxU = cliente.obtenerUsuarioPorNombre(((UsuarioLst)lstContactos.Items[0]).nombre);
                        receptor = auxU;
                        llenarLstMensajes(auxU.idUsuario);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (receptor != null)
            {
                llenarLstMensajes(receptor.idUsuario);
                Console.WriteLine("bbb");
            }
            else
            {
                try
                {
                    ServicioChat.Usuario auxU = cliente.obtenerUsuarioPorNombre(((UsuarioLst)lstContactos.Items[0]).nombre);
                    receptor = auxU;
                    Console.WriteLine("aaa");
                    llenarLstMensajes(auxU.idUsuario);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
