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
using CapaNegocio;
using CapaServicios;

namespace CapaGUI
{
    public partial class PantallaPerfilCliente : Form
    {
        public PantallaPerfilCliente()
        {
            InitializeComponent();
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
            MenuCliente pantCliente = new MenuCliente();
            pantCliente.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        // Busca la sesion para el cliente actual.
        private String SesionUsuario()
        {
            //VERSION CON WEB SERVICE
            //try
            //{
            //    ServiceReferenceWeb.WebServiceUsuarioWebSoapClient auxWeb = new ServiceReferenceWeb.WebServiceUsuarioWebSoapClient();
            //    String id = auxWeb.ServiceSesion().ToString();
            //    return id;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
            //    Console.WriteLine("Problemas con la sesion " + ex + "\n");
            //    return null;
            //}
            //VERSION CAPA NEGOCIO
            try
            {
                NegocioLogin negocio = new NegocioLogin();
                String id = negocio.BuscaSesion();
                Console.WriteLine("dfaSSSSSSSSsfsa" + id);
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
            //EN WEBSERVICE
            //////////////////////////////////////////////////////////////////
            //try
            //{
            //    ServiceReferenceEmpleado.WebServiceUsuarioEmpleadoSoapClient auxEmpleado = new WebServiceUsuarioEmpleadoSoapClient();
            //    String filtro = "tbUsuario_IdUsuario";
            //    String valor = SesionUsuario().ToString();
            //    return auxEmpleado.ServiceBuscaProducto(filtro, valor);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
            //    Console.WriteLine("Problemas con Cliente " + ex + "\n");
            //    return null;
            //}
            //////////////////////////////
            ///EN NEGOCIO
            try
            {
                NegocioCliente negocio = new NegocioCliente();
                String filtro = "tbUsuario_IdUsuario";
                String valor = SesionUsuario();
                Console.WriteLine("fsafsaf" + filtro + "fasfas" + valor);
                return negocio.BuscaCliente(filtro, valor);
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
                //esto FALLA
                dt = BuscaCliente();
                txtIdCliente.Text = (dt.Rows[0]["tbUsuario_IdUsuario"]).ToString();
                Console.WriteLine("porque no quieres funcionar uwu" + txtIdCliente.Text);
                txtNombreCompleto.Text = (String)dt.Rows[0]["NombreCompleto"];
                Console.WriteLine("porque no quieres funcionar uwu2" + txtNombreCompleto.Text);
                txtEdad.Text = (dt.Rows[0]["Edad"]).ToString();
                Console.WriteLine("porque no quieres funcionar uwu3" + txtEdad.Text);
                txtEmail.Text = (String)dt.Rows[0]["Email"];
                Console.WriteLine("porque no quieres funcionar uwu4" + txtEmail.Text);
                txtSexo.Text = (String)dt.Rows[0]["Sexo"];
                Console.WriteLine("porque no quieres funcionar uwu5" + txtSexo.Text);
                txtTelefono.Text = (dt.Rows[0]["Telefono"]).ToString();
                Console.WriteLine("DIME QUE SI" + txtTelefono.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("UwU!" + "\n" + "Hay problemas con su sesion, deberia volver a ingresar");
                Console.WriteLine("Problemas con la sesion " + ex + "\n");
            }
        }
    }
}
