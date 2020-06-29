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
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
        }
        private void MenúEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnPantAdminProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaAdministrarProductos pantAdminProd = new PantallaAdministrarProductos();
            pantAdminProd.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPantRevisarCotizaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login pLogin = new Login();
            pLogin.ShowDialog();
        }

        private void btnPantAdminCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PantallaAdministradorClientes pantAdminCli = new PantallaAdministradorClientes();
            pantAdminCli.ShowDialog();
        }
    }
}
