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
    public partial class PantallaAdministrarProductos : Form
    {
        public PantallaAdministrarProductos()
        {
            InitializeComponent();
        }

        private void btnListarProducto_Click(object sender, EventArgs e)
        {
            ServiceReferenceProducto.WebServiceProductoSoapClient auxServiceProducto = new ServiceReferenceProducto.WebServiceProductoSoapClient();
            this.dataGridViewProductos.DataSource = auxServiceProducto.ServiceListaProducto();
            this.dataGridViewProductos.DataMember = "tbProducto";
        }
    }
}
