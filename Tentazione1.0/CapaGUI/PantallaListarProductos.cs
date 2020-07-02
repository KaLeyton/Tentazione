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
    public partial class PantallaListarProductos : Form
    {
        public PantallaListarProductos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceWeb.WebServiceUsuarioWebSoapClient auxProducto = new ServiceReferenceWeb.WebServiceUsuarioWebSoapClient();
                String filtro = "NombreProducto";
                this.dataGridViewListaProductos.DataSource = auxProducto.ServiceListaProducto(filtro, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar Productos " + ex + "\n");
            }

        }
    }
}
