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
    public partial class PantallaCrearCliente : Form
    {
        public PantallaCrearCliente()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(this.txtNombreCompleto.Text) ||
            //    String.IsNullOrEmpty(this.txtEdad.Text) ||
            //    String.IsNullOrEmpty(this.txtTelefono.Text) ||
            //    String.IsNullOrEmpty(this.txtEmail.Text) ||
            //    String.IsNullOrEmpty(this.txtSexo.Text))
            //{
            //    MessageBox.Show("Ingresar Datos");
            //}
            //else
            //{
            //    ServiceReferenceUsuario.WebServiceUsuarioSoapClient auxServiceReferenceUsuario = new ServiceReferenceUsuario.WebServiceUsuarioSoapClient();
            //    ServiceReferenceUsuario.Usuario auxUsuario = new ServiceReferenceUsuario.Usuario();
            //    auxUsuario.NombreUsuario = this.txtNombreCompleto.Text;
            //    auxUsuario.Edad = 
            //}
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
