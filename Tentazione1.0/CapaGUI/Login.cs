using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using CapaServicios;
using CapaNegocio;

namespace CapaGUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login aLogin = new Login();
            /////////////METODO WEB SERVICE
            //ServiceReferenceWeb.WebServiceUsuarioWebSoapClient auxLogin = new ServiceReferenceWeb.WebServiceUsuarioWebSoapClient();
            /////////////METODO NEGOCIO
            NegocioLogin auxLogin = new NegocioLogin();
            String nombre = this.txtNombreUsuario.Text;
            String contrasena = this.txtContrasena.Text;
            Console.WriteLine(nombre + "AAAAAAAAA" + contrasena);
            try
            {
                ///////////////METODO WEB SERVICE
                //String respuesta = auxLogin.ServiceValidaLogIn(nombre, contrasena);
                //////////////METODO NEGOCIO
                String respuesta = auxLogin.ValidaLogIn(nombre, contrasena);
                Console.WriteLine("SSSSSSSSSSS" + respuesta);
                if (respuesta.Equals("Cliente"))
                {
                    MessageBox.Show("Estimado Cliente, Bienvenido");
                    MenuCliente pantCliente = new MenuCliente();
                    pantCliente.ShowDialog();
                }
                else if (respuesta.Equals("Empleado"))
                {
                    MessageBox.Show("Estimado Empleado, produce plata");
                    MenuEmpleado pantEmpleado = new MenuEmpleado();
                    pantEmpleado.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error de logIn :  " + ex + "\n");
                MessageBox.Show("UwU!" + "\n" + "No se encuentra en el sistema,"+ "\n" 
                                    + "si cree que fue un error contacte con el administrador.");
            }
            aLogin.Dispose();
        }
        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            PantallaListarProductos pantListar = new PantallaListarProductos();
            pantListar.ShowDialog();
        }
        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            ServiceReferenceWeb.WebServiceUsuarioWebSoapClient auxUsuario = new ServiceReferenceWeb.WebServiceUsuarioWebSoapClient();
            String nombre = this.txtNombreUsuario.Text;
            String contrasena = this.txtContrasena.Text;
            try
            {   // Verifica si se creo correctamente el usuario
                if (auxUsuario.ServiceRegistrarUsuario(nombre,contrasena))
                {
                    MessageBox.Show("Ingresar Datos Válidos", "Utilice sus credeciales para iniciar sesion.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error, el nombre de usuario ya se encuentra registrado " + ex + "\n");
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
