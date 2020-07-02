using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaServicios;

namespace CapaGUI
{
    public partial class PantallaPerfilCliente : Form
    {
        public PantallaPerfilCliente()
        {
            InitializeComponent();
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
            MenuCliente pantCliente = new MenuCliente();
            pantCliente.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServiceReferenceCliente.WebServiceUsuarioClienteSoapClient auxCliente = new ServiceReferenceCliente.WebServiceUsuarioClienteSoapClient();
            ServiceReferenceCliente.Cliente cliente = new ServiceReferenceCliente.Cliente();
            //todo
        }
    }
}
