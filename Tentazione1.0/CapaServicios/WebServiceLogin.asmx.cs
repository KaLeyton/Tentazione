using CapaInstanciadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServiceLogin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceLogin : System.Web.Services.WebService
    {

        [WebMethod]
        public String SValidaLogIn(String nombre, String contrasena)
        {
            IntegracionLogin auxLogin = new IntegracionLogin();
            return auxLogin.IValidaLogIn(nombre, contrasena);
        }
        // Devuelve la sesion de los usuarios para manejo de en la capa grafica.
        [WebMethod]
        public String SBuscaSesion()
        {
            IntegracionLogin auxLogin = new IntegracionLogin();
            return auxLogin.IBuscaSesion();
        }
    }
}
