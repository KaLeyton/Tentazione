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
    /// Summary description for WebServiceUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUsuario : System.Web.Services.WebService
    {

        [WebMethod]
        public int SRegistrarUsuario(String nombre, String contra)
        {
            IntegracionUsuario auxUsuario = new IntegracionUsuario();
            return auxUsuario.IRegistrarUsuario(nombre, contra);
        }
        // Listara los usuarios mediante columna y sentido para ordear.
        [WebMethod]
        public DataTable SListarUsuario(String filtro, bool sentido)
        {
            IntegracionUsuario auxUsuario = new IntegracionUsuario();
            return auxUsuario.IListarUsuario(filtro, sentido);
        }
        // Busca un usuario por valor y retorna.
        [WebMethod]
        public Usuario SBuscaUsuarioObj(String filtro, String valor)
        {
            IntegracionUsuario auxUsuario = new IntegracionUsuario();
            return auxUsuario.IBuscaUsuario(filtro, valor);
        }
        // Busca usuario por filtro y valor, retorna string.
        [WebMethod]
        public string SBuscaUsuarioString(String filtro, String valor, bool esId)
        {
            IntegracionUsuario auxUsuario = new IntegracionUsuario();
            return auxUsuario.IBuscaUsuario(filtro, valor, esId);
        }
        // Actualzia usuario mediante el objeto y retorna una validacion.
        [WebMethod]
        public bool SActualizaUsuario(Usuario usuario)
        {
            IntegracionUsuario auxUsuario = new IntegracionUsuario();
            return auxUsuario.IActualizaUsuario(usuario);
        }
        // Elimina Usuario y retorna una confirmacion.
        [WebMethod]
        public bool SEliminaUsuario(int id)
        {
            IntegracionUsuario auxUsuario = new IntegracionUsuario();
            return auxUsuario.IEliminaUsuario(id);
        }
        // Registra el ID del usuario en cliente.
        [WebMethod]
        public bool SCreaCliente(int id)
        {
            IntegracionUsuario auxUsuario = new IntegracionUsuario();
            return auxUsuario.ICreaCliente(id);
        }

        // Busca el ultimo id
        [WebMethod]
        public int SUltimoUsuario()
        {
            IntegracionUsuario auxUsuario = new IntegracionUsuario();
            return auxUsuario.IUltimoUsuario();
        }
    }
}
