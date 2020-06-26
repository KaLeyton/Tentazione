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
using System.Runtime.InteropServices.WindowsRuntime;

namespace CapaNegocio
{
    public class NegocioLogin
    {

        private Conexion conect;

        public Conexion Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            this.conect = new Conexion();
            this.Conect.NombreBaseDeDatos = "Tentazione";
            this.Conect.NombreTabla = "tbUsuario";
            this.Conect.CadenaConexion = "Data Source=DESKTOP-3PBKU9H;Initial Catalog=Tentazione;Integrated Security=True";
        }

        //public bool Validalogin(String nombre, String contrasena)
        //{
        //    List<Usuario> usuario = new List<Usuario> usuario();
        //    this.configurarConexion();
        //    this.Conect.CadenaSQL = "SELECT NombreUsuario, Contrasena FROM tbUsuario WHERE NombreUsuario = '"
        //                             + nombre + "' AND Contrasena = '" + contrasena + "';";
        //    this.Conect.EsSelect = true;
        //    this.Conect.conectar();

        //    foreach (DataRow test in this.Conect.DbDataSet)
        //    {
        //        if (test[0].Equals(nombre) && test[1].Equals(contrasena)return true;
        //    }
        //    return false;
        //}
    }
}
