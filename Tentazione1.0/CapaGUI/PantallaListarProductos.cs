using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
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
        // Retorna todos los productos
        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioProducto auxProducto = new NegocioProducto();
                String filtro = "NombreProducto";
                this.dataGridViewListaProductos.DataSource = auxProducto.ListaProducto(filtro, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar Productos " + ex + "\n");
            }
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

        // Busca producto para por nombre de producto
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioProducto auxProducto = new NegocioProducto();
                this.dataGridViewListaProductos.DataSource = BuscaProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su busqueda, deberia volver a ingresar");
                Console.WriteLine("Error al buscar Productos " + ex + "\n");
            }
        }
        // Lista todos los productos al entrar al usuario
        private void PantallaListarProductos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                NegocioProducto auxProducto = new NegocioProducto();
                String filtro = "NombreProducto";
                this.dataGridViewListaProductos.DataSource = auxProducto.ListaProducto(filtro, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
            }
        }
        // Busca productos por nombre
        private DataTable BuscaProducto()
        {
            try
            {
                NegocioProducto auxProducto = new NegocioProducto();
                String filtro = "NombreProducto";
                return auxProducto.BuscaProducto(filtro, txtBuscarProducto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con Cliente " + ex + "\n");
                return null;
            }
        }
    }
 }
