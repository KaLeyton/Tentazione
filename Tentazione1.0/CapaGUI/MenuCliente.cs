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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnPantGenerarCotizacion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PantallaGenerarCotizacion pantGenCot = new PantallaGenerarCotizacion();
            pantGenCot.Show();
            //MenuEmpleado pantEmpleado = new MenuEmpleado();
            //pantEmpleado.ShowDialog();
        }

        private void btnPantRevisarCotizaciones_Click(object sender, EventArgs e)
        {
            //xdxd
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
