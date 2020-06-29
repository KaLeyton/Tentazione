using System;
using System.Data;
using CapaConexion;

namespace CapaUtiles
{
    public class Utils
    {
        private Conexion conect;
        public Conexion Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            this.conect = new Conexion();
            this.Conect.NombreBaseDeDatos = "Tentazione";
            this.Conect.CadenaConexion = "Data Source=DESKTOP-3PBKU9H;Initial Catalog=Tentazione;Integrated Security=True";
        }

        //Utilitario, recibe los datos para query configurados desde negocio y devuelve un DataSet.
        //Valor debe ir con un formato dependiendo de si es String o numeric.
        public DataSet ListaUtils(String filtro, String valor, bool sentido, String tabla)
        {
            try
            {
                this.configurarConexion();
                this.Conect.NombreTabla = tabla;
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