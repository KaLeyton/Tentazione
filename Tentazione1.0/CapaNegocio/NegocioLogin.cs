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
        //Recibe la tabla para abir conexion, en este caso solo busca.
        private DataTable BuscaDatos(String sqlQuery, String tabla)
        {
            try
            {
                Utils util = new Utils();
                return util.ConfigurarConexion(tabla, sqlQuery);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
        }

        public bool ValidaLogIn(Usuario usuario)
        {
            try
            {
                String CadenaSQL = "SELECT NombreUsuario, Contrasena FROM tbUsuario WHERE NombreUsuario = '"
                                         + usuario.NombreUsuario + "' AND Contrasena = '" + usuario.Contrasena + "';";
                //Valida que esto retorne un valor bueno.
                if (BuscaDatos("tbUsuario", CadenaSQL).Rows.Count == 1)
                {
                    MessageBox.Show("Por fin dice que esta wea funciona WHOHOO");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }
    }
}
