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
    /// Summary description for WebServiceUsuarioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceUsuarioWeb : System.Web.Services.WebService
    {
        //Se le entrega un usuario y este valida que se encuentre en la base de datos con nombre y contraseña.
        [WebMethod]
        public bool ServiceValidaLogIn(Usuario usuario)
        {
            NegocioLogin auxLogin = new NegocioLogin();
            return auxLogin.ValidaLogIn(usuario);
        }
    }
}
