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
    /// Summary description for WebServiceUsuarioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceUsuarioWeb : System.Web.Services.WebService
    {
        // Se le entrega un usuario y este valida que se encuentre en la base de datos con nombre y contraseña.
        // Retorna el rol de usuario.
        [WebMethod]
        public String ServiceValidaLogIn(String nombre, String contrasena)
        {
            NegocioLogin auxLogin = new NegocioLogin();
            return auxLogin.ValidaLogIn(nombre, contrasena);
        }
        // Busca todos los productos y ordena segun parametro.
        [WebMethod]
        public DataTable ServiceListaProducto(String filtro, bool sentido)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.ListaProducto(filtro, sentido);
        }
        // Busca 1 solo producto por valor. (aunque existan 2 iguales e DB)
        [WebMethod]
        public Producto ServiceBuscaProducto(String filtro, String valor)
        {
            NegocioProducto auxProducto = new NegocioProducto();
            return auxProducto.BuscaProducto(filtro, valor);
        }
        // Crea un nuevo usuario
        [WebMethod]
        public bool ServiceRegistrarUsuario(Usuario usuario)
        {
            NegocioUsuario auxUsuario = new NegocioUsuario();
            return auxUsuario.RegistrarUsuario(usuario);
        }
    }
}
