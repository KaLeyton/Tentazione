using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
// sacar despues
using CapaInstanciadora;
using CapaDTO;

namespace CapaGUI
{
    public partial class PantallaAdministradorClientes : MaterialForm
    {
        bool edicionActiva = false;
        public PantallaAdministradorClientes()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }
        // Deshabilita campos
        public void desHabilitarCampos()
        {
            this.txtNombrecompleto.Enabled = false;
            this.txtEdad.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtSexo.Enabled = false;
        }
        // Deshabilita el id
        public void desHabilitarId()
        {
            this.txtIdCliente.Enabled = false;
        }
        // Habilita campos
        public void habilitarCampos()
        {
            this.txtNombrecompleto.Enabled = true;
            this.txtEdad.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtSexo.Enabled = true;
        }
        // habilita id
        public void habilitarId()
        {
            this.txtIdCliente.Enabled = true;
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login pLogin = new Login();
            pLogin.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (edicionActiva)
                {
                    desHabilitarCampos();
                }
                if (edicionActiva == false)
                {
                    this.Dispose();
                    MenuEmpleado pantEmpleado = new MenuEmpleado();
                    pantEmpleado.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo administrar clientes, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.txtIdCliente.Text = String.Empty;
        }

        private void txtNombrecompleto_Click(object sender, EventArgs e)
        {
            this.txtNombrecompleto.Text = String.Empty;
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
        // Busca clientes
        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewClientes.DataSource = BuscaClientes();
                habilitarId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo clientes, deberia volver a ingresar");
                Console.WriteLine("Problemas con listar clientes " + ex + "\n");
            }
        }
        // busca cliente
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            IntegracionCliente auxCliente = new IntegracionCliente();
            try
            {
                String filtro = "tbUsuario_IdUsuario";
                int id = Int32.Parse(txtIdCliente.Text);
                dt = auxCliente.IBuscaCliente(filtro, id);
                this.dataGridViewClientes.DataSource = dt;
                // Seteo de las columnas
                txtIdCliente.Text = id.ToString();
                // If Ternario, gracias Cuder San.
                // Utilizado para seteo de campos txt.
                txtNombrecompleto.Text = (dt.Rows[0]["NombreCompleto"] == DBNull.Value) ? string.Empty : dt.Rows[0]["NombreCompleto"].ToString();
                txtEdad.Text = (dt.Rows[0]["Edad"] == DBNull.Value) ? string.Empty : dt.Rows[0]["Edad"].ToString();
                txtTelefono.Text = (dt.Rows[0]["Telefono"] == DBNull.Value) ? string.Empty : dt.Rows[0]["Telefono"].ToString();
                txtTelefono.Text = (dt.Rows[0]["Email"] == DBNull.Value) ? string.Empty : dt.Rows[0]["Email"].ToString();
                txtTelefono.Text = (dt.Rows[0]["Sexo"] == DBNull.Value) ? string.Empty : dt.Rows[0]["Sexo"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo Clientes, deberia volver a ingresar");
                Console.WriteLine("Problemas con la busqueda de Cliente " + ex + "\n");
            }
        }
        // Edita cliente
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                desHabilitarId();
                habilitarCampos();
                edicionActiva = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo Clientes, deberia volver a ingresar");
                Console.WriteLine("Problemas con la busqueda de Clientes " + ex + "\n");
            }
        }
        // Elimina cliente
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                IntegracionCliente auxCliente = new IntegracionCliente();
                if (auxCliente.IEliminaCliente(Int32.Parse(txtIdCliente.Text)))
                {
                    MessageBox.Show("Se ha eliminado correctamente");
                    edicionActiva = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo productos, deberia volver a ingresar");
                Console.WriteLine("Problemas con eliminar Producto " + ex + "\n");
            }
        }
        // Lista todos los clientes al ingresar al menu
        private void PantallaAdministradorClientes_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewClientes.DataSource = BuscaClientes();
                desHabilitarCampos();
                habilitarId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo productos, deberia volver a ingresar");
                Console.WriteLine("Problemas con Producto " + ex + "\n");
            }
        }
        // Retorna los productos actuales para su uso
        private DataTable BuscaClientes()
        {
            try
            {
                IntegracionCliente auxCliente = new IntegracionCliente();
                String filtro = "tbUsuario_IdUsuario";
                return auxCliente.IListaCliente(filtro, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo clientes, deberia volver a ingresar");
                Console.WriteLine("Problemas la lista de clientes " + ex + "\n");
                return null;
            }
        }
        // Ingresa un nuevo cliente
        // D E M O
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            PantallaCrearUsuario auxCrearUsuario = new PantallaCrearUsuario();
            auxCrearUsuario.ShowDialog();
            try
            {
                IntegracionCliente auxCliente = new IntegracionCliente();
                Cliente cliente = new Cliente();
                cliente.TbUsuario_IdUsuario = int.Parse(txtIdCliente.Text);
                cliente.NombreCompleto = txtNombrecompleto.Text;
                cliente.Email = txtEmail.Text;
                cliente.Edad = Int32.Parse(txtEdad.Text);
                cliente.Sexo = txtSexo.Text;
                cliente.Telefono = Int32.Parse(txtTelefono.Text);
                Console.WriteLine("debug : " + cliente.TbUsuario_IdUsuario);
                if (auxCliente.IRegistrarCliente(cliente))
                {
                    edicionActiva = false;
                    MessageBox.Show("Se a ingresado a cliente correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas el modulo cliente, deberia volver a ingresar");
                Console.WriteLine("Problemas con la creacion de cliente " + ex + "\n");
            }
        }
        // guarda cliente
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                IntegracionUsuario auxUsuario = new IntegracionUsuario();
                IntegracionCliente auxCliente = new IntegracionCliente();
                Cliente cliente = new Cliente();
                cliente.TbUsuario_IdUsuario = auxUsuario.IUltimoUsuario();
                cliente.NombreCompleto = txtNombrecompleto.Text;
                cliente.Edad = int.Parse(txtEdad.Text);
                cliente.Email = txtEmail.Text;
                cliente.Sexo = txtSexo.Text;
                cliente.Telefono = int.Parse(txtTelefono.Text);
                desHabilitarCampos();
                if (auxCliente.IActualizaCliente(cliente))
                {
                    edicionActiva = false;
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

        // Busca la sesion activa del programa, para este MVP se sacrifico seguridad y escalabilidad, siendo limitado a 1 solo usuario a la vez.
        // En futuras iteraciones se modificara.
        public String BuscaSesion()
        {
            IntegracionLogin auxUtils = new IntegracionLogin();
            try
            {
                String id = auxUtils.IBuscaSesion(); 
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine("Hay problemas en la busqueda de sesiones :  " + e + "\n");
                return null;
            }
        }
    }
}
