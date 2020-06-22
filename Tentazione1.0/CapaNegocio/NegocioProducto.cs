using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;

namespace CapaNegocio
{
    class NegocioProducto
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configCon()
        {
            this.Con = new Conexion();
            this.Con.NombreBaseDeDatos = "Tentazione";
            this.Con.CadenaConexion = "Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True";
        }


    }
}
