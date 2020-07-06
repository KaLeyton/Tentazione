using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInstanciadora
{
    public class IntegracionProducto
    {
        // Registra un producto por objeto y retorna una validacion.
        public bool IRegistrarProducto(Producto producto)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.RegistrarProducto(producto);
        }
        // Metodo para listar productos columna y retorna una lista.
        public DataTable IListaProducto(String filtro, bool sentido)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.ListaProducto(filtro, sentido);
        }
        // Metodo para buscar productos por columna y valor.
        public DataTable IBuscaProducto(String filtro, String valor)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.BuscaProducto(filtro, valor);
        }
        // Actualiza un producto, seleccionado por objeto y retorna una validacion.
        public bool IActualizaProducto(Producto producto)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.ActualizaProducto(producto);
        }
        // Elimina un producto, filtrado por Sku y retorna una validacion.
        public bool IEliminaProducto(String sku)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.EliminaProducto(sku);
        }
    }
}
