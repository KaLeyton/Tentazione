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

        private String Sku { get => sku; set => sku = value; }
        private String NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        private int Valor { get => valor; set => valor = value; }
        private String Imagen { get => imagen; set => imagen = value; }
        private String UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
    }
}
