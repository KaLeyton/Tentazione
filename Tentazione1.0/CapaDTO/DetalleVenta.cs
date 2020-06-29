using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class DetalleVenta
    {
        private int idDetalleVenta;
        private double unidadesProducto;
        private String tbProductoExtendido_CodBarra;

        public int IdDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public double UnidadesProducto { get => unidadesProducto; set => unidadesProducto = value; }
        public String TbProductoExtendido_CodBarra { get => tbProductoExtendido_CodBarra; set => tbProductoExtendido_CodBarra = value; }

    }
}
