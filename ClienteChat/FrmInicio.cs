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
    public partial class FrmInicio : Form
    {
        ServicioChat.ChatServiceClient cliente;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cliente = new ServicioChat.ChatServiceClient();
            /*OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBox1.LoadFile(openFile1.FileName);
            }*/
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ServicioChat.Usuario usuarioChat;
            usuarioChat = cliente.iniciarSesion(txtNumCelular.Text, txtClave.Text);
            if(usuarioChat != null)
            {
                MessageBox.Show(usuarioChat.nombre);
                FrmChat frmChat = new FrmChat(cliente, usuarioChat);
                frmChat.Show();
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }
    }
}
