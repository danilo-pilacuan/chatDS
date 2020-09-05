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
    }
}
