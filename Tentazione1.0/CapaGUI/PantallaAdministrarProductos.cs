﻿using System;
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

        private void cbxUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login pLogin = new Login();
            pLogin.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuEmpleado pantEmpleado = new MenuEmpleado();
            pantEmpleado.ShowDialog();
        }
    }
}
