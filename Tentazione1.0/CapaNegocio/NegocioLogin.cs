using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;
using CapaConexion;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocio
{
    class NegocioLogin
    {

        private Conexion conect;

        public Conexion Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            this.Conect = new Conexion();
            this.Conect.NombreBaseDeDatos = "Tentazione";
            this.Conect.CadenaConexion = "Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True";
        }

        public void login()
        {
            SqlConnection conect = new SqlConnection();
            conect.ConnectionString = "Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True";
            conect.Open();
            string nombreUsuario = txtNombreUsuario.Text;
            string contrasena = txtContrasena.Text;
            SqlCommand cmd = new SqlCommand("select NombreUsuario,Contrasena from tbUsuario where Nombreusuario='" + txtNombreUsuario.Text + "'and Contrasena='" + txtContrasena.Text + "'", conect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess");
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            conect.Close();
        }



    }
}
