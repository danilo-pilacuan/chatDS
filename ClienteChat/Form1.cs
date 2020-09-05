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
    public partial class Form1 : Form
    {
        ServicioChat.ChatServiceClient cliente;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cliente = new ServicioChat.ChatServiceClient();
            
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ServicioChat.Usuario usuarioChat;
            usuarioChat = cliente.iniciarSesion(txtNumCelular.Text, txtClave.Text);
            if(usuarioChat != null)
            {
                MessageBox.Show(usuarioChat.nombre);
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }
    }
}
