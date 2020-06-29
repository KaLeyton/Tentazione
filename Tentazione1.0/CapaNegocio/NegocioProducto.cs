using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;

namespace CapaNegocio
{
    public class NegocioProducto
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
        public void RegistrarProducto(Producto producto)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "INSERT INTO tbProducto (SkuProducto,NombreProducto,Valor,CantPaquete,UnidadMedida) VALUES ('"
                                         + producto.Sku + "','" + producto.NombreProducto + "',"
                                         + producto.Valor + ",'" + producto.CantPaquete + "','" + producto.UnidadMedida + "');";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                _ = e.Message;
            }
        }
        public DataSet ListarProducto()
        {
            DataSet dt = new DataSet();
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "SELECT * FROM tbProducto;";
                this.Conect.EsSelect = true;
                this.Conect.conectar();

                return NegocioUtils
            }
            catch (Exception e)
            {
                //return null;
                _ = e.Message;
            }
            return this.conect.DbDataSet;
        }
        //Metodo para buscar productos columna, debe recibir un bool que indicara si es descendiente o ascediente. 
        //Filtro corresponde al valor de la columna y columna a segun que realiza el filtro. 
        //Puede recibir cualquier cosa.
        public Producto BuscaProducto(String filtro, String valor, bool sentido)
        {
            Producto auxProducto = new Producto();
            DataTable dt = new DataTable();
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "SELECT * FROM tbProducto WHERE " + filtro + " = '"
                                         + valor + "' ORDER BY ;";
                this.Conect.EsSelect = true;
                this.Conect.conectar();
                dt = this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
            }
            catch (Exception e)
            {
                _ = e.Message;
            }
            return auxProducto;
        }

        public void ActualizaProducto(Producto producto)
        {
            try
            {
                this.configurarConexion();
                this.Conect.EsSelect = false;
                this.Conect.CadenaSQL = "UPDATE tbProducto SET NombreProducto = '" + producto.NombreProducto + "', Valor = " 
                                        + producto.Valor + ", CantPaquete = '" + producto.CantPaquete + "', UnidadMedida = '"
                                        + producto.UnidadMedida + "' WHERE SkuProducto = '" + producto.Sku + "';"; 
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                _ = e.Message;
            }
        }
        public void EliminaProducto(String sku)
        {
            try
            {
                this.configurarConexion();
                this.Conect.EsSelect = false;
                this.Conect.CadenaSQL = "DELETE FROM tbProducto WHERE IdProducto = '" + sku + "';";
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                _ = e.Message;
            }
        }
    }
}
