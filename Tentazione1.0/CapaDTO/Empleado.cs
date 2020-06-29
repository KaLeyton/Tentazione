using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Empleado
    {
        private String nombreCompleto;
        private int edad;
        private int telefono;
        private String email;
        private String sexo;
        private int tbUsuario_IdUsuario;

        public String NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public String Email { get => email; set => email = value; }
        public String Sexo { get => sexo; set => sexo = value; }
        public int TbUsuario_IdUsuario { get => tbUsuario_IdUsuario; set => tbUsuario_IdUsuario = value; }
    }
}
