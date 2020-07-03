using CapaDTO;
using CapaNegocio;
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
        bool edicionActiva = false;
        public PantallaAdministrarProductos()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }
        // Deshabilita los textos
        public void desHabilitarCampos()
        {
            this.txtCantPaquete.Enabled = false;
            this.txtNombreProducto.Enabled = false;
            this.txtValor.Enabled = false;
            this.cbxUnidadMedida.Enabled = false;
        }
        // Deshabilita el id
        public void desHabilitarId()
        {
            this.txtSku.Enabled = false;
        }
        // Hablita los campos
        public void habilitarCampos()
        {
            this.txtCantPaquete.Enabled = true;
            this.txtNombreProducto.Enabled = true;
            this.txtValor.Enabled = true;
            this.cbxUnidadMedida.Enabled = true;
        }
        private void txtNombreProucto_Click(object sender, EventArgs e)
        {
            this.txtBuscarProducto.Text = String.Empty;
        }

        private void txtSku_Click(object sender, EventArgs e)
        {
            this.txtSku.Text = String.Empty;
        }

        private void txtNombreProducto_Click(object sender, EventArgs e)
        {
            this.txtBuscarProducto.Text = String.Empty;
        }

        private void txtValor_Click(object sender, EventArgs e)
        {
            this.txtValor.Text = String.Empty;
        }

        private void txtCantPaquete_Click(object sender, EventArgs e)
        {
            this.txtCantPaquete.Text = String.Empty;
        }
        // Busca un solo producto
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                String valor = txtBuscarProducto.Text;
                string filtro = "NombreProducto";
                NegocioProducto auxProducto = new NegocioProducto();
                dt = auxProducto.BuscaProducto(filtro, valor);
                this.dataGridViewProductos.DataSource = dt;
                // Seteo de las columnas
                txtNombreProducto.Text = (String)dt.Rows[0][filtro];
                txtSku.Text = dt.Rows[0]["SkuProducto"].ToString();
                txtValor.Text = dt.Rows[0]["Valor"].ToString();
                txtCantPaquete.Text = dt.Rows[0]["CantPaquete"].ToString();
                cbxUnidadMedida.Text = dt.Rows[0]["UnidadMedida"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo productos, deberia volver a ingresar");
                Console.WriteLine("Problemas con la busqueda de producto " + ex + "\n");
            }
        }
        // Modifica producto con nuevos valores
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioProducto auxProducto = new NegocioProducto();
                Producto producto = new Producto();

                producto.NombreProducto = txtNombreProducto.Text;
                producto.Valor = Int32.Parse(txtValor.Text);
                producto.CantPaquete = Int32.Parse(txtCantPaquete.Text);
                producto.UnidadMedida = cbxUnidadMedida.Text;
                habilitarCampos();

                if (auxProducto.RegistrarProducto(producto))
                {
                    edicionActiva = false;
                    MessageBox.Show("Se a ingresado su producto correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo productos, deberia volver a ingresar");
                Console.WriteLine("Problemas con la creacion de producto " + ex + "\n");
            }
        }
        // Guarda los productos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioProducto auxProducto = new NegocioProducto();
                Producto producto = new Producto();
                producto.Sku = txtSku.Text;
                producto.NombreProducto = txtNombreProducto.Text;
                producto.Valor = Int32.Parse(txtValor.Text);
                producto.CantPaquete = Int32.Parse(txtCantPaquete.Text);
                producto.UnidadMedida = cbxUnidadMedida.Text;

                if (auxProducto.ActualizaProducto(producto))
                {
                    desHabilitarCampos();
                    edicionActiva = false;
                    MessageBox.Show("Se a ingresado su producto correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo productos, deberia volver a ingresar");
                Console.WriteLine("Problemas con el ingreso de productos " + ex + "\n");
            }
        }
        // Deshabilita los campos o cierra sesion segun estado de edicion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (edicionActiva)
            {
                desHabilitarCampos();
            }
            if (edicionActiva == false)
            {
                this.Dispose();
                MenuCliente pantCliente = new MenuCliente();
                pantCliente.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Lista todos los productos al iniciar la vista
        private void PantallaAdministrarProductos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                NegocioProducto auxProducto = new NegocioProducto();
                this.dataGridViewProductos.DataSource = BuscaProductos();
                desHabilitarCampos();
                desHabilitarId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo productos, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
            }
        }
        // Retorna los productos actuales para su uso
        private DataTable BuscaProductos()
        {
            try
            {
                NegocioProducto auxProducto = new NegocioProducto();
                String filtro = "SkuProducto";
                return auxProducto.ListaProducto(filtro, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo productos, deberia volver a ingresar");
                Console.WriteLine("Problemas con Producto " + ex + "\n");
                return null;
            }
        }
        // Lista todos los productos disponibles
        private void btnListarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewProductos.DataSource = BuscaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo productos, deberia volver a ingresar");
                Console.WriteLine("Problemas con Producto " + ex + "\n");
            }
        }
        // Habilita edicion
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            edicionActiva = true;
        }
    }
}
