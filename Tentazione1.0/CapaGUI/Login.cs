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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ServiceReferenceUsuario.WebServiceUsuarioSoapClient auxServiceReferenceUsuario = new ServiceReferenceUsuario.WebServiceUsuarioSoapClient();
            ServiceReferenceUsuario.Usuario auxUsuario = new ServiceReferenceUsuario.Usuario
            {
                IdUsuario = 1111,
                NombreUsuario = "Chupalo",
                Contrasena = "Entonces"
            };

            auxServiceReferenceUsuario.ServiceRegistrarUsuario(auxUsuario);

        }

    }
}
