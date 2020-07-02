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
    /// Summary description for WebServiceUsuarioEmpleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUsuarioEmpleado : System.Web.Services.WebService
    {
        // Registra un producto nuevo utilizando objeto producto.
        [WebMethod]
        public bool ServiceRegistrarProducto(Producto producto)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.RegistrarProducto(producto);
        }
        // Actualiza un producto existente utilizando objeto producto.
        [WebMethod]
        public bool ServiceActualizaProducto(Producto producto)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.ActualizaProducto(producto);
        }
        // Lista todos los productos utilizando un filtro y el sentido.
        [WebMethod]
        public DataTable ServiceListaProducto(String filtro, bool sentido)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.ListaProducto(filtro, sentido);
        }
        // Busca un solo producto por columna y valor.
        [WebMethod]
        public DataTable ServiceBuscaProducto(String filtro, String valor)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.BuscaProducto(filtro, valor);
        }
        // Elimina un producto mediante la llave primaria
        [WebMethod]
        public bool ServiceEliminaProducto(String sku)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.EliminaProducto(sku);
        }
        // Lista todos los clientes
        [WebMethod]
        public DataTable ServiceListaCliente(String filtro, bool sentido)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.ListaCliente(filtro, sentido);
        }
        // Busca a un cliente por columna
        [WebMethod]
        public DataTable ServiceBuscaCliente(String filtro, String valor)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.BuscaCliente(filtro, valor);
        }
        // Actualiza Cliente por objeto
        [WebMethod]
        public bool ServiceActualizaCliente(Cliente cliente)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.ActualizaCliente(cliente);
        }
        // Elimina clientes
        [WebMethod]
        public bool ServiceEliminaCliente(int id)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.EliminaCliente(id);
        }
        // actualiza sus credenciales
        [WebMethod]
        public bool ActualizaUsuario(Usuario usuario)
        {
            NegocioUsuario auxUsuario = new NegocioUsuario();
            return auxUsuario.ActualizaUsuario(usuario);
        }
    }
}
