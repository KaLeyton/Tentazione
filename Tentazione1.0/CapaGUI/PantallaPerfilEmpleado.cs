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
//  borrar despues
using CapaDTO;
using CapaInstanciadora;

namespace CapaGUI
{
    public partial class PantallaPerfilEmpleado : MaterialForm
    {
        public PantallaPerfilEmpleado()
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
        // Deshabilita todos los campos menos ID
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
            this.txtIdEmpleado.Enabled = false;
        }
        // Habilita todos los campos, menos ID
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
            MenuEmpleado pantEmpleado = new MenuEmpleado();
            pantEmpleado.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login pLogin = new Login();
            pLogin.ShowDialog();
        }
        // Se cargan los datos del empleado
        private void PantallaPerfilEmpleado_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = BuscaEmpleado();
                txtIdEmpleado.Text = (dt.Rows[0]["tbUsuario_IdUsuario"]).ToString();
                txtNombreCompleto.Text = (String)dt.Rows[0]["NombreCompleto"];
                txtEdad.Text = (dt.Rows[0]["Edad"]).ToString();
                txtEmail.Text = (String)dt.Rows[0]["Email"];
                txtSexo.Text = (String)dt.Rows[0]["Sexo"];
                txtTelefono.Text = (dt.Rows[0]["Telefono"]).ToString();
                // Deja bloqueados los campos
                desHabilitarCampos();
                desHabilitarId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
            }
        }
        // Busca la sesion para el empleado actual.
        private String SesionUsuario()
        {
            try
            {
                IntegracionLogin auxWeb = new IntegracionLogin();
                String id = auxWeb.IBuscaSesion();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
                return null;
            }
        }
        // Retorna el Empleado actual para su uso
        private DataTable BuscaEmpleado()
        {
            try
            {
                IntegracionEmpleado auxEmpleado = new IntegracionEmpleado();
                String filtro = "tbUsuario_IdUsuario";
                String valor = SesionUsuario();
                return auxEmpleado.IBuscaEmpleado(filtro, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con Cliente " + ex + "\n");
                return null;
            }
        }
        // Guarda modificaciones a perfil
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                IntegracionEmpleado auxEmpleado = new IntegracionEmpleado();
                Empleado empleado = new Empleado();
                empleado.TbUsuario_IdUsuario = int.Parse(txtIdEmpleado.Text);
                empleado.NombreCompleto = txtNombreCompleto.Text;
                empleado.Edad = int.Parse(txtEdad.Text);
                empleado.Email = txtEmail.Text;
                empleado.Sexo = txtSexo.Text;
                empleado.Telefono = int.Parse(txtTelefono.Text);

                if (auxEmpleado.IActualizaEmpleado(empleado))
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
        // Permite editar los campos.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }
    }
}
