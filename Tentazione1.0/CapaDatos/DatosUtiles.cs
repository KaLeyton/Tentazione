using System;
using System.Data;
using System.Text.RegularExpressions;
using CapaConexion;
using CapaDTO;


namespace CapaDatos
{
    public class Utils
    {
        private Conexion conect;
        public Conexion Conect { get => conect; set => conect = value; }

        // Abre Conexion, es util para metodos particulares.
        public void ConfigurarConexion(String tabla)
        {
            try
            {
                this.conect = new Conexion();
                this.Conect.NombreBaseDeDatos = "Tentazione";
                this.Conect.CadenaConexion = "Data Source=DESKTOP-3PBKU9H;Initial Catalog=Tentazione;Integrated Security=True";
                this.Conect.NombreTabla = tabla;
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al configurar conexion " + e + "\n");
            }
        }
        // Metodo para seleccionar datos y retornar un DataTable
        public DataTable ConfigurarConexion(String tabla, String sqlQuery)
        {
            try
            {
                this.conect = new Conexion();
                this.Conect.NombreBaseDeDatos = "Tentazione";
                this.Conect.CadenaConexion = "Data Source=DESKTOP-3PBKU9H;Initial Catalog=Tentazione;Integrated Security=True";
                this.Conect.NombreTabla = tabla;
                this.Conect.CadenaSQL = sqlQuery;
                Console.WriteLine("CHATO"+tabla + "asfasf" +sqlQuery);
                this.Conect.EsSelect = true;
                this.Conect.conectar();
                return this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al configurar conexion2 " + e + "\n");
                return null;
            }
        }
        // Metodo para insertar datos segun parametros a base de datos.
        public bool ConfigurarConexion(String tabla, String sqlQuery, bool NoSelect)
        {
            try
            {
                this.conect = new Conexion();
                this.Conect.NombreBaseDeDatos = "Tentazione";
                this.Conect.CadenaConexion = "Data Source=DESKTOP-3PBKU9H;Initial Catalog=Tentazione;Integrated Security=True";
                this.Conect.NombreTabla = tabla;
                this.Conect.CadenaSQL = sqlQuery;
                this.Conect.EsSelect = NoSelect;
                this.Conect.conectar();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al configurar conexion3 " + e + "\n");
                return false;
            }
        }
        // Utilitario, recibe los datos para query configurados desde negocio y devuelve un DataSet, version para strings.
        // Lista por valor de columna.
        public DataTable ListaUtils(String filtro, String valor, bool sentido, String tabla)
        {
            try
            {
                this.ConfigurarConexion(tabla);
                this.Conect.EsSelect = true;
                this.Conect.CadenaSQL = "SELECT * FROM " + tabla + " WHERE " + filtro;
                this.Conect.CadenaSQL += " = '" + valor + "' ORDER BY " + filtro;
                Console.WriteLine("ya no quiero mas guerra1" + this.Conect.CadenaSQL);
                if (sentido == true)
                {
                    this.Conect.CadenaSQL += " DESC;";
                    Console.WriteLine("ya no quiero mas guerra2" + this.Conect.CadenaSQL);
                }
                else if(sentido == false)
                {
                    this.Conect.CadenaSQL += " ASC;";
                    Console.WriteLine("ya no quiero mas guerra3" + this.Conect.CadenaSQL);
                }
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al utilizar listaUtil1 " + e + "\n");
                return null;
            }
            return this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
        }
        // Version para int
        public DataTable ListaUtils(String filtro, int valor, bool sentido, String tabla)
        {
            try
            {
                this.ConfigurarConexion(tabla);
                this.Conect.EsSelect = true;
                this.Conect.CadenaSQL = "SELECT * FROM " + tabla + " WHERE " + filtro;
                this.Conect.CadenaSQL += " = " + valor + " ORDER BY " + filtro;
                if (sentido == true)
                {
                    this.Conect.CadenaSQL += " DESC;";
                    Console.WriteLine("ya no quiero mas guerra4" + this.Conect.CadenaSQL);
                }
                else if (sentido == false)
                {
                    this.Conect.CadenaSQL += " ASC;";
                    Console.WriteLine("ya no quiero mas guerra5" + this.Conect.CadenaSQL);
                }
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al utilizar listaUtil1 " + e + "\n");
                return null;
            }
            return this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
        }
        // Override para el metodo de Listar, este trae todos los resultados.
        public DataTable ListaUtils(String filtro, bool sentido, String tabla)
        {
            try
            {
                this.ConfigurarConexion(tabla);
                this.Conect.EsSelect = true;
                this.Conect.CadenaSQL = "SELECT * FROM " + tabla + " ORDER BY " + filtro;
                // Valida si es numerico para realizar la consulta correspondiente.
                if (sentido)
                {
                    this.Conect.CadenaSQL += " DESC;";
                }
                else
                {
                    this.Conect.CadenaSQL += " ASC;";
                }
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al utilizar listaUtil2 " + e + "\n");
                return null;
            }
            return this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
        }
        // Configura el id del usuario
        public bool ConfiguraSesion(String nombre, String contra)
        {
            DataTable dt = new DataTable();
            try
            {
                String CadenaSQL = "SELECT IdUsuario FROM tbUsuario WHERE NombreUsuario = '"
                                         + nombre + "' AND Contrasena = '" + contra + "';";
                dt = this.ConfigurarConexion("tbUsuario", CadenaSQL);
                Console.WriteLine("KIEKEIKEIEKEI" + CadenaSQL);
                String id = (String)dt.Rows[0]["IdUsuario"].ToString();
                Console.WriteLine("safasf" + id);
                return RegistraSesion(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error, fallo al configurar la sesion actual " + ex + "\n");
                return false;
            }
        }
        // Registra la sesion actual.
        private bool RegistraSesion(String id)
        {
            try
            {
                Console.WriteLine("dadssadasfaf!!!!" + id);
                String CadenaSQL = "UPDATE tbSesion SET Sesion = '"
                                    + id + "' WHERE id = 0;";
                Console.WriteLine("DIME QUE WEA"+CadenaSQL);
                return ConfigurarConexion("tbSesion", CadenaSQL, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("error, fallo al registrar la sesion actual " + ex + "\n");
                return false;
            }
        }
    }
}