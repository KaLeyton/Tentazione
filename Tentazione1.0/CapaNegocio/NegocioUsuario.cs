using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDTO;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioUsuario
    {
        // Debe recibir usuario.rol como por defecto como Cliente.
        public bool RegistrarUsuario(String nombre, String contra)
        {
            String rol = "Cliente";
            try
            {
                Utils util = new Utils();
                string CadenaSQL = "INSERT INTO tbUsuario (NombreUsuario,Contrasena,Rol) VALUES ('" 
                                    + nombre + "','"+ contra + "','" + rol + "');";

                return util.ConfigurarConexion("tbUsuario", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }
        // Listara los usuarios
        public DataTable ListarUsuario(String filtro, bool sentido)
        {
            try
            {
                Utils util = new Utils();
                return util.ListaUtils(filtro, sentido, "tbUsuario");
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
        }
        // Busca 1 usuario por columna.
        public Usuario BuscaUsuario(String filtro, String valor)
        {
            Usuario auxUsuario = new Usuario();
            try
            {
                Utils util = new Utils();
                DataTable dt = util.ListaUtils(filtro, valor, true, "tbUsuario");

                auxUsuario.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                auxUsuario.NombreUsuario = (String)dt.Rows[0]["NombreUsuario"];
                auxUsuario.Contrasena = (String)dt.Rows[0]["Contrasena"];
                auxUsuario.Rol = (String)dt.Rows[0]["Rol"];
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
            return auxUsuario;
        }
        // Insertar metodo que liste varios usuarios por filtro.
        // [MEJORA CONTINUA]

        // busca el id del usuario, en formato de string.
        public string BuscaUsuario(String filtro, String valor, bool esId)
        {
            try
            {
                Utils util = new Utils();
                DataTable dt = util.ListaUtils(filtro, valor, esId, "tbUsuario");
                int n = (int)dt.Rows[0]["idUsuario"];
                return Convert.ToString(n);
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al buscar usuarios " + e + "\n");
                return null;
            }
        }
        // Actualiza usuario y devuelve una confirmacion.
        public bool ActualizaUsuario(Usuario usuario)
        {
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "UPDATE tbUsuario SET NombreUsuario = '" 
                                            + usuario.NombreUsuario + "', Contrasena = '" 
                                            + usuario.Contrasena + "' WHERE IdUsuario = " 
                                            + usuario.IdUsuario + ";";

                return util.ConfigurarConexion("tbUsuario", CadenaSQL, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al actualizar usuarios " + e + "\n");
                return false;
            }
        }
        // Elimina Usuario y devuelve una confirmacion
        public bool EliminaUsuario(String id)
        {
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "DELETE FROM tbUsuario WHERE IdUsuario = " + id + ";";
                return util.ConfigurarConexion("tbUsuario", CadenaSQL, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al eliminar usuarios " + e + "\n");
                return false;
            }
        }
    }
}
