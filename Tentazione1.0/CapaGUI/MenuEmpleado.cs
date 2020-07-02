using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class MenuEmpleado : MaterialForm
    {
        public MenuEmpleado()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }
        private void btnPantAdminCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PantallaAdministradorClientes pantAdminCli = new PantallaAdministradorClientes();
            pantAdminCli.ShowDialog();
        }
        private void btnPantAdminProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaAdministrarProductos pantAdminProd = new PantallaAdministrarProductos();
            pantAdminProd.ShowDialog();
        }
        private void btnPantRevisarCotizaciones_Click(object sender, EventArgs e)
        {
            PantallaRevisarCotizaciones pantRevCot = new PantallaRevisarCotizaciones();
            pantRevCot.ShowDialog();
        }
        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            PantallaPerfilEmpleado pantEditClient = new PantallaPerfilEmpleado();
            pantEditClient.ShowDialog();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login pLogin = new Login();
            pLogin.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


