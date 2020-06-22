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

        private String NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        private int Edad { get => edad; set => edad = value; }
        private int Telefono { get => telefono; set => telefono = value; }
        private String Email { get => email; set => email = value; }
        private String Sexo { get => sexo; set => sexo = value; }
        private int TbUsuario_IdUsuario { get => tbUsuario_IdUsuario; set => tbUsuario_IdUsuario = value; }
    }
}
