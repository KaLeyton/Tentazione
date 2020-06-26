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
                this.Conect.CadenaSQL = "INSERT INTO tbProducto (SkuProducto,NombreProducto,Valor,Imagen,UnidadMedida) VALUES ('"
                                         + producto.Sku + "','" + producto.NombreProducto + "',"
                                         + producto.Valor + ",'" + producto.Imagen + "','" + producto.UnidadMedida + "');";
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
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "SELECT * FROM tbProducto;";
                this.Conect.EsSelect = true;
                this.Conect.conectar();
            }
            catch (Exception e)
            {
                //return null;
                _ = e.Message;
            }
            return this.conect.DbDataSet;
        }
        //Metodo para buscar productos por Sku, util para el admin.
        public Producto BuscaProductoSku(String sku)
        {
            Producto auxProducto = new Producto();
            DataTable dt = new DataTable();
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "SELECT * FROM tbProducto WHERE SkuProducto = '"
                                         + sku + "';";
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
        //Metodo para buscar productos por nombre, util para usuario.
        public Producto BuscaProductoNombre(String nombre)
        {
            Producto auxProducto = new Producto();
            DataTable dt = new DataTable();
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "SELECT * FROM tbProducto WHERE SkuProducto = '"
                                         + nombre + "';";
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
                                        + producto.Valor + ", Imagen = '" + producto.Imagen + "', UnidadMedida = '"
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
