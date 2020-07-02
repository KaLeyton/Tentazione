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
using CapaGUI.ServiceReferenceCliente;
using CapaGUI.ServiceReferenceEmpleado;
using CapaServicios;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceCliente.Cliente cliente = new ServiceReferenceCliente.Cliente();
                ServiceReferenceCliente.WebServiceUsuarioClienteSoapClient auxCliente = new WebServiceUsuarioClienteSoapClient();
                cliente.TbUsuario_IdUsuario = int.Parse(txtIdCliente.Text);
                cliente.NombreCompleto = txtNombreCompleto.Text;
                cliente.Edad = int.Parse(txtEdad.Text);
                cliente.Email = txtEmail.Text;
                cliente.Sexo = txtSexo.Text;
                cliente.Telefono = int.Parse(txtTelefono.Text);

                if(auxCliente.ServiceActualizaCliente(cliente))
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
                ServiceReferenceWeb.WebServiceUsuarioWebSoapClient auxWeb = new ServiceReferenceWeb.WebServiceUsuarioWebSoapClient();
                String id = auxWeb.ServiceSesion();
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
                ServiceReferenceEmpleado.WebServiceUsuarioEmpleadoSoapClient auxEmpleado = new WebServiceUsuarioEmpleadoSoapClient();
                String filtro = "tbUsuario_IdUsuario";
                String valor = SesionUsuario();
                return auxEmpleado.ServiceBuscaCliente(filtro, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con Cliente " + ex + "\n");
                return null;
            }
        }
        private void PantallaPerfilCliente_Load(object sender, EventArgs e)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
            }
        }
    }
}
