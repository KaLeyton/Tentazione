using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Producto
    {
        private String sku;
        private String nombreProducto;
        private int valor;
        private String imagen;
        private String unidadMedida;

        public String Sku { get => sku; set => sku = value; }
        public String NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Valor { get => valor; set => valor = value; }
        public String Imagen { get => imagen; set => imagen = value; }
        public String UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
    }
}
