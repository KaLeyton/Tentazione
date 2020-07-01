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
            DataTable dt = new DataTable();
            ServiceReferenceWeb.WebServiceUsuarioWebSoapClient auxLogin = new ServiceReferenceWeb.WebServiceUsuarioWebSoapClient();
            dt = auxLogin.ServiceListaProducto("NombreProducto",true);
            int largo = dt.Rows.Count;
            for (int i = 0; i < largo; i++)
            {
                Console.WriteLine("chapalapachala " +i);
            }
        }
    }
}
