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
    public partial class PantallaAdministrarProductos : MaterialForm
    {
        public PantallaAdministrarProductos()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void txtNombreProucto_Click(object sender, EventArgs e)
        {
            this.txtNombreProucto.Text = String.Empty;
        }

        private void txtSku_Click(object sender, EventArgs e)
        {
            this.txtSku.Text = String.Empty;
        }

        private void txtNombreProducto_Click(object sender, EventArgs e)
        {
            this.txtNombreProucto.Text = String.Empty;
        }

        private void txtValor_Click(object sender, EventArgs e)
        {
            this.txtValor.Text = String.Empty;
        }

        private void txtCantPaquete_Click(object sender, EventArgs e)
        {
            this.txtCantPaquete.Text = String.Empty;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuEmpleado pantEmpleado = new MenuEmpleado();
            pantEmpleado.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //private void btnListarProducto_Click(object sender, EventArgs e)
        //{
        //    //ServiceReferenceProducto.WebServiceProductoSoapClient auxServiceProducto = new ServiceReferenceProducto.WebServiceProductoSoapClient();
        //    //this.dataGridViewProductos.DataSource = auxServiceProducto.ServiceListaProducto();
        //    //this.dataGridViewProductos.DataMember = "tbProducto";
        //}

        //private void cbxUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void btnCerrarSesion_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //    Login pLogin = new Login();
        //    pLogin.ShowDialog();
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //    MenuEmpleado pantEmpleado = new MenuEmpleado();
        //    pantEmpleado.ShowDialog();
        //}
    }
}
