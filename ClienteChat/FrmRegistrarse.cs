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
    public partial class FrmRegistrarse : Form
    {
        ServicioChat.ChatServiceClient cliente;
        public FrmRegistrarse()
        {
            InitializeComponent();
        }
        public FrmRegistrarse(ServicioChat.ChatServiceClient cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
        }

        private void FrmRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string numCelular;
            string claveUsuario;
            string nombre;

            numCelular = txtNumCelular.Text;
            claveUsuario = txtPass.Text;
            nombre = txtNombre.Text;
            int resultado=cliente.crearUsuario(numCelular, claveUsuario, nombre);
            if(resultado==1)
            {
                MessageBox.Show("Usuario creado exitosamente");
                this.Visible = false;
            }
            
        }
    }
}
