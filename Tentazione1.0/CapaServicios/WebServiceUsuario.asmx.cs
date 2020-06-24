using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using CapaDTO;
using System.Data;

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
        public void RegistrarUsuario(Usuario usuario)
        {
            NegocioUsuario auxNegocio = new NegocioUsuario();
            auxNegocio.RegistrarUsuario(usuario);
        }
        [WebMethod]
        public DataSet ListaUsuario()
        {
            NegocioUsuario auxNegocio = new NegocioUsuario();
            return auxNegocio.ListarUsuario();
        }
        [WebMethod]
        public Usuario BuscaUsuario(int id)
        {
            NegocioUsuario auxNegocio = new NegocioUsuario();
            return auxNegocio.BuscaUsuario(id);
        }
        [WebMethod]
        public void ActualizaUsuario(Usuario usuario)
        {
            NegocioUsuario auxNegocio = new NegocioUsuario();
            auxNegocio.ActualizaUsuario(usuario);
        }
        [WebMethod]
        public void EliminaUsuario(int id)
        {
            NegocioUsuario auxNegocio = new NegocioUsuario();
            auxNegocio.EliminaUsuario(id);
        }
    }
}
