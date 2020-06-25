using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using System.Data;

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
        public void ServiceRegistrarProducto(Producto producto)
        {
            NegocioProducto auxNegocio = new NegocioProducto();
            auxNegocio.RegistrarProducto(producto);
        }
        [WebMethod]
        public DataSet ServiceListaProducto()
        {
            NegocioProducto auxNegocio = new NegocioProducto();
            return auxNegocio.ListarProducto();
        }
        [WebMethod]
        public Producto ServiceBuscaProductoSku(String sku)
        {
            NegocioProducto auxNegocio = new NegocioProducto();
            return auxNegocio.BuscaProductoSku(sku);
        }
        [WebMethod]
        public Producto ServiceBuscaProductoNombre(String nombre)
        {
            NegocioProducto auxNegocio = new NegocioProducto();
            return auxNegocio.BuscaProductoNombre(nombre);
        }
        [WebMethod]
        public void ServiceActualizaProducto(Producto producto)
        {
            NegocioProducto auxNegocio = new NegocioProducto();
            auxNegocio.ActualizaProducto(producto);
        }
        [WebMethod]
        public void ServiceElmininaProducto(String sku)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            auxProducto.EliminaProducto(sku);
        }
    }
}
