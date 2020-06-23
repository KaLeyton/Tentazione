using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using CapaDTO;

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
            CapaNegocio.NegocioUsuario auxNegocio = new CapaNegocio.NegocioUsuario();
            auxNegocio.RegistrarUsuario(usuario);

            Console.WriteLine("wea222");
        }
    }
}
