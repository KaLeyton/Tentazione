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
    public partial class PantallaCrearCliente : Form
    {
        public PantallaCrearCliente()
        {
            InitializeComponent();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            ServiceReferenceCliente.WebServiceUsuarioClienteSoapClient auxCliente = new ServiceReferenceCliente.WebServiceUsuarioClienteSoapClient();
            ServiceReferenceCliente.Cliente cliente = new ServiceReferenceCliente.Cliente();
            try
            {

            }
            catch (Exception ex)
            {
                
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login auxLogin = new Login();
            auxLogin.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
