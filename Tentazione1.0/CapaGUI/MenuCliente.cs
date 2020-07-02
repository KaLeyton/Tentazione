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
    public partial class MenuCliente : MaterialForm
    {
        public MenuCliente()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }
        private void btnPantGenerarCotizacion_Click(object sender, EventArgs e)
        {
            PantallaGenerarCotizacion pantGenCot = new PantallaGenerarCotizacion();
            pantGenCot.Show();
            //MenuEmpleado pantEmpleado = new MenuEmpleado();
            //pantEmpleado.ShowDialog();
            this.Dispose();
        }
        private void btnRevisarCotizaciones_Click(object sender, EventArgs e)
        {

        }
        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PantallaPerfilCliente pantEditarPerfil = new PantallaPerfilCliente();
            pantEditarPerfil.ShowDialog();
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
