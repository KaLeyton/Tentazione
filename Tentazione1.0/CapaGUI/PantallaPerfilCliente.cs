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
    public partial class PantallaPerfilCliente : MaterialForm
    {
        public PantallaPerfilCliente()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void txtNombreCompleto_Click(object sender, EventArgs e)
        {
            this.txtNombreCompleto.Text = String.Empty;
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
        // Deshabilita los botones
        public void desHabilitarCampos()
        {
            this.txtEdad.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtNombreCompleto.Enabled = false;
            this.txtSexo.Enabled = false;
            this.txtTelefono.Enabled = false;
        }
        // Deshabilita ID
        public void desHabilitarId()
        {
            this.txtIdCliente.Enabled = false;
        }
        // habilita botones
        public void habilitarCampos()
        {
            this.txtEdad.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtNombreCompleto.Enabled = true;
            this.txtSexo.Enabled = true;
            this.txtTelefono.Enabled = true;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuCliente pantCliente = new MenuCliente();
            pantCliente.ShowDialog();
        }
        // Guarda cambios a productos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDTO.Cliente cliente = new CapaDTO.Cliente();
                NegocioCliente auxCliente = new NegocioCliente();
                cliente.TbUsuario_IdUsuario = int.Parse(txtIdCliente.Text);
                cliente.NombreCompleto = txtNombreCompleto.Text;
                cliente.Edad = int.Parse(txtEdad.Text);
                cliente.Email = txtEmail.Text;
                cliente.Sexo = txtSexo.Text;
                cliente.Telefono = int.Parse(txtTelefono.Text);

                if (auxCliente.ActualizaCliente(cliente))
                {
                    MessageBox.Show("Se ha actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Hay problemas con al actualizar");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("UwU!" + "\n" + "Hay problemas con el grabado de datos, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
            }

        }
        // Busca la sesion para el cliente actual.
        private String SesionUsuario()
        {
            try
            {
                NegocioLogin auxWeb = new NegocioLogin();
                String id = auxWeb.BuscaSesion();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
                return null;
            }
        }
        // Retorna el cliente actual para su uso
        private DataTable BuscaCliente()
        {
            try
            {
                NegocioCliente auxCliente = new NegocioCliente();
                String filtro = "tbUsuario_IdUsuario";
                String valor = SesionUsuario();
                return auxCliente.BuscaCliente(filtro, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con Cliente " + ex + "\n");
                return null;
            }
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login pLogin = new Login();
            pLogin.ShowDialog();
        }
        // Carga todos los productos al momento de instanciar la vista
        private void PantallaPerfilCliente_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = BuscaCliente();
                txtIdCliente.Text = (dt.Rows[0]["tbUsuario_IdUsuario"]).ToString();
                txtNombreCompleto.Text = (String)dt.Rows[0]["NombreCompleto"];
                txtEdad.Text = (dt.Rows[0]["Edad"]).ToString();
                txtEmail.Text = (String)dt.Rows[0]["Email"];
                txtSexo.Text = (String)dt.Rows[0]["Sexo"];
                txtTelefono.Text = (dt.Rows[0]["Telefono"]).ToString();

                desHabilitarCampos();
                desHabilitarId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
            }
        }
        // Habilita cmapos para edicion
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                habilitarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con la edicion de productos, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
            }
        }
    }
}