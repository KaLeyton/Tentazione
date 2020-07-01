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
            DataTable dt = new DataTable();
            try
            {
                String CadenaSQL = "SELECT Rol FROM tbUsuario WHERE NombreUsuario = '"
                                         + nombre + "' AND Contrasena = '" + contrasena + "';";
                Console.WriteLine("sssss" + CadenaSQL);
                dt = BuscaDatos(CadenaSQL, "tbUsuario");
                Console.WriteLine("ssssllllls");
                String result =  (String)dt.Rows[0]["Rol"];
                Console.WriteLine("jkfkjhaskhj" + result);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Los datos de la consulta son erroneos para la validacion del LogIn :  " + e + "\n");
                return null;
            }
        }
    }
}
