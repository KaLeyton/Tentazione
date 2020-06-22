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

        private int IdDetalleCotizacion { get => idDetalleCotizacion; set => idDetalleCotizacion = value; }
        private double UnidadesProducto { get => unidadesProducto; set => unidadesProducto = value; }
        private String TbProducto_SkuProducto { get => tbProducto_SkuProducto; set => tbProducto_SkuProducto = value; }

    }
}
