using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class ProductoExtendido
    {
        private String codBarra;
        private DateTime fechaElaboracion;
        private DateTime fechaVencimiento;
        private String tbProducto_SkuProducto;

        public String CodBarra { get => codBarra; set => codBarra = value; }
        public DateTime FechaElaboracion { get => fechaElaboracion; set => fechaElaboracion = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public String TbProducto_SkuProducto { get => tbProducto_SkuProducto; set => tbProducto_SkuProducto = value; }

    }
}
