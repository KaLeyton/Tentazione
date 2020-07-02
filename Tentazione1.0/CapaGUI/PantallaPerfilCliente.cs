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
    public partial class PantallaPerfilCliente : MaterialForm
    {
        public PantallaPerfilCliente()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void txtNombreCompleto_Click(object sender, EventArgs e)
        {
            this.txtNombreCompleto.Text = String.Empty;
        }

        private void txtEdad_Click(object sender, EventArgs e)
        {
            this.txtEdad.Text = String.Empty;
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            this.txtTelefono.Text = String.Empty;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            this.txtEmail.Text = String.Empty;
        }

        private void txtSexo_Click(object sender, EventArgs e)
        {
            this.txtSexo.Text = String.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuCliente pantCliente = new MenuCliente();
            pantCliente.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login pLogin = new Login();
            pLogin.ShowDialog();
        }
    }
}
