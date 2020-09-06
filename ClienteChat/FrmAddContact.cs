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
    public partial class FrmAddContact : Form
    {
        ServicioChat.ChatServiceClient cliente;
        ServicioChat.Usuario usuario;
        
        List<ServicioChat.Usuario> listaUsuarios;
        public FrmAddContact()
        {
            InitializeComponent();
        } 
        public FrmAddContact(ServicioChat.ChatServiceClient cliente, ServicioChat.Usuario usuario)
        {
            this.cliente = cliente;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void FormAddContact_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ServicioChat.Contacto nuevoC = new ServicioChat.Contacto();
            nuevoC.idUsuarioEmisor = usuario.idUsuario;
            listaUsuarios = cliente.obtenerUsuarios().ToList();
            nuevoC.idUsuarioReceptor = 0;
            foreach (ServicioChat.Usuario iterU in listaUsuarios)
            {
                if(iterU.numCelular == txtNumCelular.Text)
                {
                    nuevoC.idUsuarioReceptor = iterU.idUsuario;
                    break;
                }
            }
            if (nuevoC.idUsuarioReceptor == 0)
                MessageBox.Show("El usuario no existe");
            else
            {

                int resultado = cliente.agregarContacto(nuevoC.idUsuarioEmisor, txtNumCelular.Text);
                if(resultado==0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    MessageBox.Show("Contacto agregado con éxito");
                }
            }
        }
    }
}
