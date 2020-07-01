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
using CapaDTO;
using CapaNegocio;
using System.Threading;

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
            //this.Dispose();
            MenuCliente pantCliente = new MenuCliente();
            Login aLogin = new Login();
            try
            {
                //ServiceReferenceUsuario.WebServiceUsuarioSoapClient auxLogin = new ServiceReferenceUsuario.WebServiceUsuarioSoapClient();
                //ServiceReferenceUsuario.Usuario newUsuario = new ServiceReferenceUsuario.Usuario();
                //newUsuario.NombreUsuario = this.txtNombreUsuario.Text;
                //newUsuario.Contrasena = this.txtContrasena.Text;
                //auxLogin.ServiceValidaLogIn(newUsuario);
                //bool duro = true;
                //if (duro)

                //{
                
                if (this.txtNombreUsuario.Text.Equals("Cliente"))
                    {
                        
                        MessageBox.Show("Cliente", "Bienvenido");
                        //this.Dispose();
                        
                        pantCliente.ShowDialog();
                        //this.Close();
                    }
                    else if (this.txtNombreUsuario.Text.Equals("Empleado"))
                    {
                        MessageBox.Show("Empleado", "Bienvenido");
                        MenuEmpleado pantEmpleado = new MenuEmpleado();
                        pantEmpleado.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ingresar Datos Válidos", "Alerta!");
                    }
                   // this.Close();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine("error ql :  " + ex + "\n");
            }
            //this.Dispose();
            aLogin.Dispose();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            PantallaListarProductos pantListar = new PantallaListarProductos();
            pantListar.ShowDialog();
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            PantallaCrearCliente pCrear = new PantallaCrearCliente();
            pCrear.ShowDialog();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////Como hacer todo esto.
        ////private void btnLogin_Click(object sender, EventArgs e)
        ////{
        //ServiceReferenceUsuario.WebServiceUsuarioSoapClient auxLogin = new ServiceReferenceUsuario.WebServiceUsuarioSoapClient();
        //ServiceReferenceUsuario.Usuario newUsuario = new ServiceReferenceUsuario.Usuario();
        //newUsuario.NombreUsuario = this.txtNombreUsuario.Text;
        //    newUsuario.Contrasena = this.txtContrasena.Text;
        //    auxLogin.ServiceValidaLogIn(newUsuario);
        ////}

        //metodo de prueba para ver si funciona.
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ServiceReferenceUsuario.WebServiceUsuarioSoapClient auxServiceReferenceUsuario = new ServiceReferenceUsuario.WebServiceUsuarioSoapClient();
        //        ServiceReferenceUsuario.Usuario auxUsuario = new ServiceReferenceUsuario.Usuario
        //        {
        //            IdUsuario = 7777,
        //            NombreUsuario = "qeuis",
        //            Contrasena = "Uno",
        //            Rol = "Cliente"
        //        };

        //        auxServiceReferenceUsuario.ServiceRegistrarUsuario(auxUsuario);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("error ql :  " + ex + "\n");
        //    }

        //}

    }
}
