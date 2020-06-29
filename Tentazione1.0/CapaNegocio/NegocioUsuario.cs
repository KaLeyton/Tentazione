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
        //Debe recibir usuario.rol como por defecto como Cliente.
        public bool RegistrarUsuario(Usuario usuario)
        {
            try
            {
                Utils util = new Utils();
                string CadenaSQL = "INSERT INTO tbUsuario (IdUsuario,NombreUsuario,Contrasena,Rol) VALUES ("
                                         + usuario.IdUsuario + ",'" + usuario.NombreUsuario + "','"
                                         + usuario.Contrasena + "','" + usuario.Rol + "');";

                return util.ConfigurarConexion("tbUsuario", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }
        //Listara los usuarios
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
        //Busca 1 usuario por columna.
        public Usuario BuscaUsuario(String filtro, String valor)
        {
            Usuario auxUsuario = new Usuario();
            try
            {
                Utils util = new Utils();
                DataTable dt = util.ListaUtils(filtro, valor, true, "tbUsuario");

                auxUsuario.IdUsuario = (int)dt.Rows[0]["idUsuario"];
                auxUsuario.NombreUsuario = (String)dt.Rows[0]["nombreUsuario"];
                auxUsuario.Contrasena = (String)dt.Rows[0]["contrasena"];
                auxUsuario.Rol = (String)dt.Rows[0]["rol"];
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
            return auxUsuario;
        }
        //Insertar metodo que liste varios usuarios por filtro.

        //Actualiza usuario y devuelve una confirmacion.
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
                _ = e.Message;
                return false;
            }
        }
        //Elimina Usuario y devuelve una confirmacion
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
                _ = e.Message;
                return false;
            }
        }

    }
}
