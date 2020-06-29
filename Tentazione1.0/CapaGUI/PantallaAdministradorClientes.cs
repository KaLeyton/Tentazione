using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class PantallaAdministradorClientes : Form
    {
        public PantallaAdministradorClientes()
        {
            InitializeComponent();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            ServiceReferenceUsuario.WebServiceUsuarioSoapClient auxServiceCliente = new ServiceReferenceUsuario.WebServiceUsuarioSoapClient();
            this.dataGridViewClientes.DataSource = auxServiceCliente.ServiceListaUsuario();
            this.dataGridViewClientes.DataMember = "tbUsuario";
            //this.dataGridViewClientes.DataBindings();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login pLogin = new Login();
            pLogin.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuEmpleado pantEmpleado = new MenuEmpleado();
            pantEmpleado.ShowDialog();
        }
    }
}
