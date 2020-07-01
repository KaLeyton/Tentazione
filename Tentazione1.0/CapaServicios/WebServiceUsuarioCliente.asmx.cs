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
    /// Summary description for WebServiceUsuarioCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUsuarioCliente : System.Web.Services.WebService
    {
        // Actualiza datos de usuario, pw y correo.
        [WebMethod]
        public bool ServiceActualizaUsuario(Usuario usuario)
        {
            NegocioUsuario auxUsuario = new NegocioUsuario();
            return auxUsuario.ActualizaUsuario(usuario);
        }
        // Registra datos de cliente.
        [WebMethod]
        public bool ServiceRegistraCliente(Cliente cliente)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.RegistrarCliente(cliente);
        }
        // Actualiza datos de cliente
        [WebMethod]
        public bool ServiceActualizaCliente(Cliente cliente)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.ActualizaCliente(cliente);
        }
        // Lista todos los productos y ordena segun parametro.
        [WebMethod]
        public DataTable ServiceListaProducto(String filtro, bool sentido)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.ListaProducto(filtro, sentido);
        }
        // Busca un producto en particular.
        [WebMethod]
        public Producto ServiceBuscaProducto(String filtro, String valor)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.BuscaProducto(filtro, valor);
        }
    }
}
