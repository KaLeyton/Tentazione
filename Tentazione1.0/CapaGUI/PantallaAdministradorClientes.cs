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
using MaterialSkin;
using MaterialSkin.Controls;

namespace CapaGUI
{
    public partial class PantallaAdministradorClientes : MaterialForm
    {
        public PantallaAdministradorClientes()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuEmpleado pantEmpleado = new MenuEmpleado();
            pantEmpleado.ShowDialog();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            //    ServiceReferenceEmpleado.WebServiceUsuarioEmpleadoSoapClient auxServiceCliente = new ServiceReferenceEmpleado.WebServiceUsuarioEmpleadoSoapClient();
            //    String filtro = "tbUsuario_IdUsuario";
            //    this.dataGridViewClientes.DataSource = auxServiceCliente.ServiceListaCliente(filtro,true);
            //    //this.dataGridViewClientes.DataMember = "tbUsuario";
            //    //this.dataGridViewClientes.DataBindings();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.txtIdCliente.Text = String.Empty;
        }

        private void txtNombrecompleto_Click(object sender, EventArgs e)
        {
            this.txtNombrecompleto.Text = String.Empty;
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
