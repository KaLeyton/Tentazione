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
        private double cantPaquete;
        private String unidadMedida;

<<<<<<< HEAD
        public String Sku { get => sku; set => sku = value; }
        public String NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Valor { get => valor; set => valor = value; }
        public String Imagen { get => imagen; set => imagen = value; }
        public String UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
=======
        private String Sku { get => sku; set => sku = value; }
        private String NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        private int Valor { get => valor; set => valor = value; }
        private double CantPaquete { get => cantPaquete; set => cantPaquete = value; }
        private String UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
>>>>>>> 07a584c... agregue pantallas capaGUI, Modifique base de datos y capa DTO, agregue vistas capaGUIWeb
    }
}
