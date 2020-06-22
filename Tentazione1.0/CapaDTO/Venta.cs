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

        private int IdVenta { get => idVenta; set => idVenta = value; }
        private DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        private double MontoVenta { get => montoVenta; set => montoVenta = value; }
        private String DetalleVenta { get => detalleVenta; set => detalleVenta = value; }
        private int TbCotizacion_IdCotizacion { get => tbCotizacion_IdCotizacion; set => tbCotizacion_IdCotizacion = value; }
        private int TbEmpleado_tbUsuario_IdUsuario { get => tbEmpleado_tbUsuario_IdUsuario; set => tbEmpleado_tbUsuario_IdUsuario = value; }
        private int TbCliente_tbUsuario_IdUsuario { get => tbCliente_tbUsuario_IdUsuario; set => tbCliente_tbUsuario_IdUsuario = value; }

    }
}
