using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class DetalleCotizacion
    {
        private int idDetalleCotizacion;
        private double unidadesProducto;
        private String tbProducto_SkuProducto;

        public int IdDetalleCotizacion { get => idDetalleCotizacion; set => idDetalleCotizacion = value; }
        public double UnidadesProducto { get => unidadesProducto; set => unidadesProducto = value; }
        public String TbProducto_SkuProducto { get => tbProducto_SkuProducto; set => tbProducto_SkuProducto = value; }

    }
}
