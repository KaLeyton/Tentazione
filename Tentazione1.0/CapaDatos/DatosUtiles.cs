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
                this.Conect.CadenaConexion = "Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True";
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
                this.Conect.CadenaConexion = "Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True";
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
                    this.Conect.CadenaSQL += "DESC;";
                }
                else
                {
                    this.Conect.CadenaSQL += "ASC;";
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
    }
}