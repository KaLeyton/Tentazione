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

namespace CapaGUI
{
    public partial class Login : Form
    {
        SqlConnection conect = new SqlConnection();
        public Login()
        {
            //SqlConnection conect = new SqlConnection();
            conect.ConnectionString = "Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True";
            InitializeComponent();
        }

        public void login()
        {
            SqlConnection conect = new SqlConnection("Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True");
            conect.Open();
        }

        //Como hacer todo esto.
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    ServiceReferenceUsuario.WebServiceUsuarioSoapClient auxLogin = new ServiceReferenceUsuario.WebServiceUsuarioSoapClient();
        //    ServiceReferenceUsuario.Usuario newUsuario = new ServiceReferenceUsuario.Usuario();
        //    newUsuario.NombreUsuario = this.txtNombreUsuario.Text;
        //    newUsuario.Contrasena = this.txtContrasena.Text;
        //    auxLogin.ServiceValidaLogIn(newUsuario);
        //}
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceUsuario.WebServiceUsuarioSoapClient auxServiceReferenceUsuario = new ServiceReferenceUsuario.WebServiceUsuarioSoapClient();
                ServiceReferenceUsuario.Usuario auxUsuario = new ServiceReferenceUsuario.Usuario
                {
                    IdUsuario = 7777,
                    NombreUsuario = "qeuis",
                    Contrasena = "Uno",
                    Rol = "Cliente"
                };

                auxServiceReferenceUsuario.ServiceRegistrarUsuario(auxUsuario);

            }
            catch (Exception ex)
            {
                Console.WriteLine("error ql :  " + ex + "\n");
            }
            
        }

    }
}
