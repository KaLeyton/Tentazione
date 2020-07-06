using CapaGUI.ServiceUsuario;
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
    public partial class PantallaCrearUsuario : MaterialForm
    {
        public PantallaCrearUsuario()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.Brown500, Accent.LightBlue700, TextShade.WHITE);
        }
        // Crea usuario y para que inserte.
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            WebServiceUsuarioSoapClient auxUsuario = new WebServiceUsuarioSoapClient();
            String nombre = this.txtNombreUsuario.Text;
            String contrasena = this.txtContrasena.Text;
            int valida = auxUsuario.SRegistrarUsuario(nombre, contrasena);
            // devolver ID o registrar
            try
            {   // Verifica si se creo correctamente el usuario
                if (valida > 0)
                {
                    if (auxUsuario.SCreaCliente(valida))
                    {
                        MessageBox.Show("Datos Válidos", "Utilice sus credeciales para iniciar sesion.");
                    }
                    else
                    {
                        MessageBox.Show("UwU!" + "\n" + "Hubo un problema con su solicitud, intente otra vez");
                        Console.WriteLine("error al asignar sus id se usuario para cliente" + "\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error, el nombre de usuario ya se encuentra registrado " + ex + "\n");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantallaAdministradorClientes auxpantadmin = new PantallaAdministradorClientes();
            auxpantadmin.ShowDialog();
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNombreUsuario_Click(object sender, EventArgs e)
        {
            this.txtNombreUsuario.Text = String.Empty;
        }

        private void txtContrasena_Click_1(object sender, EventArgs e)
        {
            this.txtContrasena.Text = String.Empty;
        }
    }
}
