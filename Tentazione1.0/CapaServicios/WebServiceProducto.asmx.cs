using CapaDTO;
using CapaInstanciadora;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServiceProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceProducto : System.Web.Services.WebService
    {

        [WebMethod]
        public bool SRegistrarProducto(Producto producto)
        {
            IntegracionProducto auxProducto = new IntegracionProducto();
            return auxProducto.IRegistrarProducto(producto);
        }
        // Metodo para listar productos columna y retorna una lista.
        [WebMethod]
        public DataTable SListaProducto(String filtro, bool sentido)
        {
            IntegracionProducto auxProducto = new IntegracionProducto();
            return auxProducto.IListaProducto(filtro, sentido);
        }
        // Metodo para buscar productos por columna y valor.
        [WebMethod]
        public DataTable SBuscaProducto(String filtro, String valor)
        {
            IntegracionProducto auxProducto = new IntegracionProducto();
            return auxProducto.IBuscaProducto(filtro, valor);
        }
        // Actualiza un producto, seleccionado por objeto y retorna una validacion.
        [WebMethod]
        public bool SActualizaProducto(Producto producto)
        {
            IntegracionProducto auxProducto = new IntegracionProducto();
            return auxProducto.IActualizaProducto(producto);
        }
        // Elimina un producto, filtrado por Sku y retorna una validacion.
        [WebMethod]
        public bool SEliminaProducto(String sku)
        {
            IntegracionProducto auxProducto = new IntegracionProducto();
            return auxProducto.IEliminaProducto(sku);
        }
    }
}
