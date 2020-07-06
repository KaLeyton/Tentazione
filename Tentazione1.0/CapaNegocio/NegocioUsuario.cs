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
        public int RegistrarUsuario(String nombre, String contra)
        {
            DataTable dt = new DataTable();
            String rol = "Cliente";
            try
            {
                Utils util = new Utils();
                string CadenaSQL = "INSERT INTO tbUsuario (NombreUsuario,Contrasena,Rol) VALUES ('" 
                                    + nombre + "','"+ contra + "','" + rol + "');";               
                if (util.ConfigurarConexion("tbUsuario", CadenaSQL, false))
                {
                    return util.UltimoUsuario();
                }
                else
                {
                    Console.WriteLine("error, fallo al registrar su usuario en BD" + "\n");
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al registrar su usuario " + e + "\n");
                return 0;
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
                Console.WriteLine("error, fallo al listar usuarios " + e + "\n");
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
                Console.WriteLine("error, fallo al buscar el usuario " + e + "\n");
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
        // Elimina Usuario y devuelve una confirmacion.
        public bool EliminaUsuario(int id)
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
        // Registra id de usuario creado en tabla cliente
        public bool CreaCliente(int id)
        {       
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "INSERT INTO tbCliente (tbUsuario_IdUsuario) VALUES (" + id + ");";
                return util.ConfigurarConexion("tbCliente", CadenaSQL, false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error, fallo al ingresar ID de usuari la tabla cliente " + ex + "\n");
                return false;
            }
        }
        // Busca el ultimo id de usuario creado
        public int UltimoUsuario()
        {
            try
            {
                Utils util = new Utils();
                return util.UltimoUsuario();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error, fallo al buscar el ultimo ID de usuario en la tabla " + ex + "\n");
                return 0;
            }            
        }
    }
}
