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
    /// Summary description for WebServiceEmpleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceEmpleado : System.Web.Services.WebService
    {

        [WebMethod]
        // Metodo para listar Empleados por columna.
        public DataTable SListaEmpleado(String filtro, bool sentido)
        {
            IntegracionEmpleado auxEmpleado = new IntegracionEmpleado();
            return auxEmpleado.IListaEmpleado(filtro, sentido);
        }
        // Envia un registro de Empleado, retorna una confirmacion y retorna ua validacion.
        [WebMethod]
        public bool SRegistrarEmpleado(Empleado empleado)
        {
            IntegracionEmpleado auxEmpleado = new IntegracionEmpleado();
            return auxEmpleado.IRegistrarEmpleado(empleado);
        }
        // Busca un empleado determinado con columna, filtrando por el valor y retorna una validacion.
        [WebMethod]
        public DataTable SBuscaEmpleado(String filtro, String valor)
        {
            IntegracionEmpleado auxEmpleado = new IntegracionEmpleado();
            return auxEmpleado.IBuscaEmpleado(filtro, valor);
        }
        // Actualiza un empleado mediante un objetivo, filtrando por objeto y retorna una validacion.
        [WebMethod]
        public bool SActualizaEmpleado(Empleado empleado)
        {
            IntegracionEmpleado auxEmpleado = new IntegracionEmpleado();
            return auxEmpleado.IActualizaEmpleado(empleado);
        }
        // Elimina un Empleado, filtrado por su id y retorna una validacion.
        [WebMethod]
        public bool SEliminaEmpleado(int id)
        {
            IntegracionEmpleado auxEmpleado = new IntegracionEmpleado();
            return auxEmpleado.IEliminaEmpleado(id);
        }
    }
}
