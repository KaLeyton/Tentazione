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

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    SqlConnection conect = new SqlConnection();
        //    conect.ConnectionString = "Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True";
        //    conect.Open();
        //    string nombreUsuario = txtNombreUsuario.Text;
        //    string contrasena = txtContrasena.Text;
        //    SqlCommand cmd = new SqlCommand("select NombreUsuario,Contrasena from tbUsuario where Nombreusuario='" + txtNombreUsuario.Text + "'and Contrasena='" + txtContrasena.Text + "'", conect);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        MessageBox.Show("Login sucess");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid Login please check username and password");
        //    }
        //    conect.Close();
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ServiceReferenceUsuario.WebServiceUsuarioSoapClient auxServiceReferencenceUsuario = new ServiceReferenceUsuario.WebServiceUsuarioSoapClient();

            ServiceReferenceUsuario.Usuario auxUsuario = new ServiceReferenceUsuario.Usuario();

            Console.WriteLine("KAKAKAKKAKA");

            String user = "kaka";
            String contr = "faff";
            int id = 1313;

            auxUsuario.IdUsuario = id;
            auxUsuario.NombreUsuario = user;
            auxUsuario.Contrasena = contr;
            Console.WriteLine(auxUsuario.Contrasena);
            Console.WriteLine(auxUsuario.NombreUsuario);
            Console.WriteLine(auxUsuario.IdUsuario);
        }
    }
}
