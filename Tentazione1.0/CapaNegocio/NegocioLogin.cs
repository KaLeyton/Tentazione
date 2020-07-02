using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioLogin
    {
        // Recibe la tabla para abir conexion, en este caso solo busca.
        private DataTable BuscaDatos(String sqlQuery, String tabla)
        {
            try
            {
                Utils util = new Utils();
                return util.ConfigurarConexion(tabla, sqlQuery);
            }
            catch (Exception e)
            {
                Console.WriteLine("error en conexion para BuscaDatos :  " + e + "\n");
                return null;
            }
        }
        // Devuelve una respuesta sobre si las credenciales son correctas.
        public String ValidaLogIn(String nombre, String contrasena)
        {
            Utils util = new Utils();
            DataTable dt = new DataTable();
            try
            {
                String CadenaSQL = "SELECT Rol FROM tbUsuario WHERE NombreUsuario = '"
                                         + nombre + "' AND Contrasena = '" + contrasena + "';";
                dt = BuscaDatos(CadenaSQL, "tbUsuario");
                String result =  (String)dt.Rows[0]["Rol"];
                // Invoca la configuracion
                try
                {
                    util.ConfiguraSesion(nombre, contrasena);
                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la asignacion de sesion :  " + ex + "\n");
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Los datos de la consulta son erroneos para la validacion del LogIn :  " + e + "\n");
                return null;
            }
        }
        // Busca la sesion activa del programa, para este MVP se sacrifico seguridad y escalabilidad, siendo limitado a 1 solo usuario a la vez.
        // En futuras iteraciones se modificara.
        public String BuscaSesion()
        {
            Utils utils = new Utils();
            DataTable dt = new DataTable();
            try
            {
                String CadenaSQL = "SELECT * FROM tbSesion;";
                dt = utils.ConfigurarConexion("tbSesion", CadenaSQL);
                String id = (String)dt.Rows[0]["Sesion"];
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine("Hay problemas en la busqueda de sesiones :  " + e + "\n");
                return null;
            }
        }
    }
}
