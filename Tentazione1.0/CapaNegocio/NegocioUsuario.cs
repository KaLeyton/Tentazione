using CapaConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDTO;
using CapaUtiles;

namespace CapaNegocio
{
    public class NegocioUsuario
    {
        private Conexion conect;
        public Conexion Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            this.conect = new Conexion();
            this.Conect.NombreBaseDeDatos = "Tentazione";
            this.Conect.NombreTabla = "tbUsuario";
            this.Conect.CadenaConexion = "Data Source=DESKTOP-3PBKU9H;Initial Catalog=Tentazione;Integrated Security=True";
        }

        //Falta configurar esto para que funcione llamando la funcion de ListaUtils.

        //FALTA esto
        public DataSet ListarUsuario(String filtro, String valor, bool sentido, bool number)
        {
            try
            {
                Utils util = new Utils();
                util.ListaUtils();
            }
            catch (Exception e)
            {
                //return null;
                _ = e.Message;
            }
            return this.conect.DbDataSet;
        }

        //debe recibir usuario.rol como por defecto como Cliente.
        public void RegistrarUsuario(Usuario usuario)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "INSERT INTO tbUsuario (IdUsuario,NombreUsuario,Contrasena,Rol) VALUES (" 
                                         + usuario.IdUsuario + ",'" + usuario.NombreUsuario + "','" 
                                         + usuario.Contrasena + "','" + usuario.Rol + "');";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                _ = e.Message;
            }
        }

        public Usuario BuscaUsuario(int id)
        {
            Usuario auxUsuario = new Usuario();
            DataTable dt = new DataTable();
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "SELECT * FROM tbUsuario WHERE IdUsuario = " 
                                         + id + ";";
                this.Conect.EsSelect = true;
                this.Conect.conectar();
                dt = this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
            }
            catch (Exception e)
            {
                _ = e.Message;
            }
            return auxUsuario;
        }

        public void ActualizaUsuario(Usuario usuario)
        {
            try
            {
                this.configurarConexion();
                this.Conect.EsSelect = false;
                this.Conect.CadenaSQL = "UPDATE tbUsuario SET NombreUsuario = '" 
                                            + usuario.NombreUsuario + "', Contrasena = '" 
                                            + usuario.Contrasena + "' WHERE IdUsuario = " 
                                            + usuario.IdUsuario + ";";
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                _ = e.Message;
            }
        }

        public void EliminaUsuario(int id)
        {
            try
            {
                this.configurarConexion();
                this.Conect.EsSelect = false;
                this.Conect.CadenaSQL = "DELETE FROM tbUsuario WHERE IdUsuario = " + id + ";";
                this.Conect.conectar();
            }
            catch (Exception e)
            {

                _ = e.Message;
            }
        }

    }
}
