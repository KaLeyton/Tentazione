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

        //Abre Conexion, es util para metodos particulares.
        public void ConfigurarConexion(String tabla)
        {
            this.conect = new Conexion();
            this.Conect.NombreBaseDeDatos = "Tentazione";
            this.Conect.CadenaConexion = "Data Source=DESKTOP-3PBKU9H;Initial Catalog=Tentazione;Integrated Security=True";
            this.Conect.NombreTabla = tabla;
        }
        //Metodo para seleccionar datos y retornar un DataTable
        public DataTable ConfigurarConexion(String tabla, String sqlQuery)
        {
            this.conect = new Conexion();
            this.Conect.NombreBaseDeDatos = "Tentazione";
            this.Conect.CadenaConexion = "Data Source=DESKTOP-3PBKU9H;Initial Catalog=Tentazione;Integrated Security=True";
            this.Conect.NombreTabla = tabla;
            this.Conect.CadenaSQL = sqlQuery;
            this.Conect.EsSelect = true;
            this.Conect.conectar();
            //Devulve un DataTable con los datos resultantes de la query
            return this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
        }
        //Metodo para insertar datos segun parametros a base de datos.
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
                _ = e.Message;
                return false;
            }
        }
        //Utilitario, recibe los datos para query configurados desde negocio y devuelve un DataSet.
        //Valor puede ser numerico o un String, para esto se aplicara una expresion regular.
        //Lista por valor de columna.
        public DataTable ListaUtils(String filtro, String valor, bool sentido, String tabla)
        {
            try
            {
                this.ConfigurarConexion(tabla);
                this.Conect.EsSelect = true;
                this.Conect.CadenaSQL = "SELECT * FROM " + tabla + " WHERE " + filtro;
                //Valida si es numerico para realizar la consulta correspondiente.
                if (Regex.IsMatch(valor, @"^\d+$"))
                {
                    this.Conect.CadenaSQL += " = " + valor + " ORDER BY ";
                    Console.WriteLine("uwuwuwu");
                }
                else
                {
                    this.Conect.CadenaSQL += " = '" + valor + "' ORDER BY ";
                    Console.WriteLine("awawawwawa");
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
                _ = e.Message;
            }
            return this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
        }
        //Override para el metodo de Listar, este trae todos los resultados.
        public DataTable ListaUtils(String filtro, bool sentido, String tabla)
        {
            try
            {
                this.ConfigurarConexion(tabla);
                this.Conect.EsSelect = true;
                this.Conect.CadenaSQL = "SELECT * FROM " + tabla + " ORDER BY " + filtro;
                //Valida si es numerico para realizar la consulta correspondiente.
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
                _ = e.Message;
            }
            return this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
        }
    }
}