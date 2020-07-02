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
    public partial class PantallaListarProductos : MaterialForm
    {
        public PantallaListarProductos()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void txtBuscarProducto_Click(object sender, EventArgs e)
        {
            this.txtBuscarProducto.Text = String.Empty;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        ServiceReferenceWeb.WebServiceUsuarioWebSoapClient auxProducto = new ServiceReferenceWeb.WebServiceUsuarioWebSoapClient();
        //        String filtro = "NombreProducto";
        //        this.dataGridViewListaProductos.DataSource = auxProducto.ServiceListaProducto(filtro, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error al listar Productos " + ex + "\n");
        //    }
            }

        private void btnLogIn_Click(object sender, EventArgs e)
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
