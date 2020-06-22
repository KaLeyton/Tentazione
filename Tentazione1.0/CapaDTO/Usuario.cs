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

        private int IdUsuario { get => idUsuario; set => idUsuario = value; }
        private String NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        private String Contrasena { get => contrasena; set => contrasena = value; }

    }
}
