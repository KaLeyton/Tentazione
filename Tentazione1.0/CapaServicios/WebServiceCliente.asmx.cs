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
    /// Summary description for WebServiceCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCliente : System.Web.Services.WebService
    {
        [WebMethod]
        public DataTable SListaCliente(String filtro, bool sentido)
        {
            IntegracionCliente auxCLiente = new IntegracionCliente();
            return auxCLiente.IListaCliente(filtro, sentido);
        }
        // Registra un cliente y retorna un boleano de confirmacion.
        [WebMethod]
        public bool SRegistrarCliente(Cliente cliente)
        {
            IntegracionCliente auxCliente = new IntegracionCliente();
            return auxCliente.IRegistrarCliente(cliente);
        }
        // Metodo Busca cliente por columna y el valor, recibe string.
        [WebMethod]
        public DataTable SBuscaClienteString(String filtro, String valor)
        {
            IntegracionCliente auxCliente = new IntegracionCliente();
            return auxCliente.IBuscaCliente(filtro, valor);
        }
        // Metodo busca cliente por columna y valor, recibe int.
        [WebMethod]
        public DataTable SBuscaClienteInt(String filtro, int valor)
        {
            IntegracionCliente auxCliente = new IntegracionCliente();
            return auxCliente.IBuscaCliente(filtro, valor);
        }
        // Actualiza un cliente, seleccionado por objeto y retorna un boleanod de confirmacion.
        [WebMethod]
        public bool SActualizaCliente(Cliente cliente)
        {
            IntegracionCliente auxCliente = new IntegracionCliente();
            return auxCliente.IActualizaCliente(cliente);
        }
        // Elimina un cliente segun ID y retorna un boleanod de confirmacion..
        [WebMethod]
        public bool SEliminaCliente(int id)
        {
            IntegracionCliente auxCliente = new IntegracionCliente();
            return auxCliente.IEliminaCliente(id);
        }
    }
}
