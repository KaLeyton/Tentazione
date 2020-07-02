﻿using System;
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
using MaterialSkin.Controls;
using MaterialSkin;

namespace CapaGUI
{
    public partial class Login : MaterialForm 
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Login aLogin = new Login();
            ServiceReferenceWeb.WebServiceUsuarioWebSoapClient auxLogin = new ServiceReferenceWeb.WebServiceUsuarioWebSoapClient();
            String nombre = this.txtNombreUsuario.Text;
            String contrasena = this.txtContrasena.Text;
            try
            {
                String respuesta = auxLogin.ServiceValidaLogIn(nombre, contrasena);
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

        private void txtNombreUsuario_Click(object sender, EventArgs e)
        {
            this.txtNombreUsuario.Text = String.Empty;
        }

        private void txtContrasena_Click(object sender, EventArgs e)
        {
            this.txtContrasena.Text = String.Empty;
        }

        private void btnVerProductos_Click_1(object sender, EventArgs e)
        {
            PantallaListarProductos pantListar = new PantallaListarProductos();
            pantListar.ShowDialog();
        }

        private void btnCrearUsuario_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
