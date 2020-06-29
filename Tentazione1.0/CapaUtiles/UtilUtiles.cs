using System;
using System.Data;
using CapaConexion;

namespace CapaDatos
{
    public class Utils
    {
        private Conexion conect;
        public Conexion Conect { get => conect; set => conect = value; }

        public void configurarConexion(String tabla)
        {
            this.conect = new Conexion();
            this.Conect.NombreBaseDeDatos = "Tentazione";
            this.Conect.CadenaConexion = "Data Source=DESKTOP-3PBKU9H;Initial Catalog=Tentazione;Integrated Security=True";
            this.Conect.NombreTabla = tabla;
        }

        //Utilitario, recibe los datos para query configurados desde negocio y devuelve un DataSet.
        //Valor debe ir con un formato dependiendo de si es String o numeric.
        public DataSet ListaUtils(String filtro, String valor, bool sentido)
        {
            try
            {
                this.configurarConexion();
                this.Conect.EsSelect = true;
                this.Conect.CadenaSQL = "SELECT * FROM " + tabla + " WHERE " + filtro + " = " + valor + " ORDER BY";
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
                //return null;
                _ = e.Message;
            }
            return this.conect.DbDataSet;
        }
    }
}