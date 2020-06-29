using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Venta
    {
        private int idVenta;
        private DateTime fechaVenta;
        private double montoVenta;
        private String detalleVenta;
        private int tbCotizacion_IdCotizacion;
        private int tbEmpleado_tbUsuario_IdUsuario;
        private int tbCliente_tbUsuario_IdUsuario;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public double MontoVenta { get => montoVenta; set => montoVenta = value; }
        public String DetalleVenta { get => detalleVenta; set => detalleVenta = value; }
        public int TbCotizacion_IdCotizacion { get => tbCotizacion_IdCotizacion; set => tbCotizacion_IdCotizacion = value; }
        public int TbEmpleado_tbUsuario_IdUsuario { get => tbEmpleado_tbUsuario_IdUsuario; set => tbEmpleado_tbUsuario_IdUsuario = value; }
        public int TbCliente_tbUsuario_IdUsuario { get => tbCliente_tbUsuario_IdUsuario; set => tbCliente_tbUsuario_IdUsuario = value; }

    }
}
