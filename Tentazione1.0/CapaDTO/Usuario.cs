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
        private String rol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public String NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public String Contrasena { get => contrasena; set => contrasena = value; }
        public String Rol { get => rol; set => rol = value; }

    }
}
