using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Cotizacion
    {
        private int idcotizacion;
        private String mensaje;
        private DateTime fechaIngreso;
        private String respuesta;
        private DateTime fechaRespuesta;
        private String estado;
        private int tbDetalleCotizacion_IdDetalleCotizacion;
        private int tbEmpleado_tbUsuario_IdUsuario;
        private int tbCliente_tbUsuario_IdUsuario;

        public int Idcotizacion { get => idcotizacion; set => idcotizacion = value; }
        public String Mensaje { get => mensaje; set => mensaje = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public String Respuesta { get => respuesta; set => respuesta = value; }
        public DateTime FechaRespuesta { get => fechaRespuesta; set => fechaRespuesta = value; }
        public String Estado { get => estado; set => estado = value; }
        public int TbDetalleCotizacion_IdDetalleCotizacion { get => tbDetalleCotizacion_IdDetalleCotizacion; set => tbDetalleCotizacion_IdDetalleCotizacion = value; }
        public int TbEmpleado_tbUsuario_IdUsuario { get => tbEmpleado_tbUsuario_IdUsuario; set => tbEmpleado_tbUsuario_IdUsuario = value; }
        public int TbCliente_tbUsuario_IdUsuario { get => tbCliente_tbUsuario_IdUsuario; set => tbCliente_tbUsuario_IdUsuario = value; }

    }
}
