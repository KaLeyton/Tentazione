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
                this.Conect.EsSelect = true;
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al configurar conexion2 " + e + "\n");
                return null;
            }
            // Devulve un DataTable con los datos resultantes de la query
            return this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
        }
        // Metodo para insertar datos segun parametros a base de datos.
        public bool ConfigurarConexion(String tabla, String sqlQuery, bool NoSelect)
        {
            try
            {
                this.conect = new Conexion();
                this.Conect.NombreBaseDeDatos = "Tentazione";
                this.Conect.CadenaConexion = "Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True";
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
        // Utilitario, recibe los datos para query configurados desde negocio y devuelve un DataSet.
        // Valor puede ser numerico o un String, para esto se aplicara una expresion regular.
        // Lista por valor de columna.
        public DataTable ListaUtils(String filtro, String valor, bool sentido, String tabla)
        {
            try
            {
                this.ConfigurarConexion(tabla);
                this.Conect.EsSelect = true;
                this.Conect.CadenaSQL = "SELECT * FROM " + tabla + " WHERE " + filtro;
                // Valida si es numerico para realizar la consulta correspondiente.
                if (Regex.IsMatch(valor, @"^\d+$"))
                {
                    this.Conect.CadenaSQL += " = " + valor + " ORDER BY ";
                }
                else
                {
                    this.Conect.CadenaSQL += " = '" + valor + "' ORDER BY ";
                }
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
        // Busca la sesion activa del programa, para este MVP se sacrifico seguridad y escalabilidad, siendo limitado a 1 solo usuario a la vez.
        // En futuras iteraciones se modificara.
        public int BuscaSesion()
        {
            DataTable dt = new DataTable();
            try
            {
                Utils utils = new Utils();
                String CadenaSQL = "SELECT id FROM tbId";
                dt = utils.ConfigurarConexion("tbId", CadenaSQL);
                int id = (int)dt.Rows[0]["id"];
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine("Hay problemas en la busqueda de sesiones :  " + e + "\n");
                return 0;
            }
        }
        // Configura el id del usuario
        public bool ConfiguraSesion(String nombre, String contra)
        {
            DataTable dt = new DataTable();
            try
            {
                Utils utils = new Utils();
                String CadenaSQL = "SELECT IdUsuario FROM tbUsuario WHERE NombreUsuario = '"
                                         + nombre + "' AND Contrasena = '" + contra + "';";
                dt = utils.ConfigurarConexion("tbUsuario", CadenaSQL);
                int id = (int)dt.Rows[0]["IdUsuario"];
                return RegistraSesion(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error, fallo al configurar la sesion actual " + ex + "\n");
                return false;
            }
        }
        // Registra la sesion actual.
        private bool RegistraSesion(int id)
        {
            try
            {
                Utils utils = new Utils();
                String CadenaSQL = "INSERT INTO tbId (id) VALUES ("
                                    + id + ");";
                return utils.ConfigurarConexion("tbId", CadenaSQL, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("error, fallo al registrar la sesion actual " + ex + "\n");
                return false;
            }
        }
    }
}