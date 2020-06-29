using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Usuario
    {
        private int idUsuario;
        private String nombreUsuario;
        private String contrasena;
        private bool rol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public String NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public String Contrasena { get => contrasena; set => contrasena = value; }
        public bool Rol { get => rol; set => rol = value; }

    }
}
