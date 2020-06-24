using CapaConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDTO;

namespace CapaNegocio
{
    public class NegocioUsuario
    {
        private Conexion conect;
        public Conexion Conect { get => conect; set => conect = value; }


        public void RegistrarUsuario(Usuario usuario)
        {
            //Declaracion de variables.
            String tabla = "tbUsuario";
            bool select = false;
            string query = "INSERT INTO " + tabla + " (IdUsuario,NombreUsuario,Contrasena) VALUES ('" + usuario.IdUsuario + "','" + usuario.NombreUsuario + "','" + usuario.Contrasena + "');";
            //Seteo de variables.
            this.Conect.NombreTabla = tabla;
            this.Conect.EsSelect = select;
            this.Conect.CadenaSQL = query;

            Console.WriteLine("xaxaxaxxa");

        }
    }
}
