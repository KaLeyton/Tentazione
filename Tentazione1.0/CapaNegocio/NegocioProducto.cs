using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        // Envia un registro de producto, retorna una confirmacion.
        public bool RegistrarProducto(Producto producto)
        {
            try
            {
                Utils utils = new Utils();
                String CadenaSQL = "INSERT INTO tbProducto (NombreProducto,Valor,CantPaquete,UnidadMedida) VALUES ('"
                                         + producto.NombreProducto + "',"
                                         + producto.Valor + ",'" + producto.CantPaquete + "','" + producto.UnidadMedida + "');";
                // Entrega confirmacion.
                return utils.ConfigurarConexion("tbProducto", CadenaSQL, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al registrar productos " + e + "\n");
                return false;
            }
        }
        // Metodo para listar productos columna.
        public DataTable ListaProducto(String filtro, bool sentido)
        {
            try
            {
                Utils util = new Utils();
                return util.ListaUtils(filtro, sentido, "tbProducto");
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al listar productos " + e + "\n");
                return null;
            }
        }
        // Metodo para buscar productos por datatable
        public DataTable BuscaProducto(String filtro, String valor)
        {
            try
            {
                Utils util = new Utils();
                return util.ListaUtils(filtro, valor, true, "tbProducto");
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al buscar productos " + e + "\n");
                return null;
            }
        }
        // Insertar metodo que liste varios productos por filtro.
        // [MEJORA CONTINUA]


        // Actualiza un producto, seleccionado por Sku
        public bool ActualizaProducto(Producto producto)
        {
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "UPDATE tbProducto SET NombreProducto = '" + producto.NombreProducto + "', Valor = " 
                                        + producto.Valor + ", CantPaquete = '" + producto.CantPaquete + "', UnidadMedida = '"
                                        + producto.UnidadMedida + "' WHERE SkuProducto = '" + producto.Sku + "';";
                return util.ConfigurarConexion("tbProducto", CadenaSQL, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al actualizar productos " + e + "\n");
                return false;
            }
        }
        // Elimina un producto, filtrado por Sku
        public bool EliminaProducto(String sku)
        {
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "DELETE FROM tbProducto WHERE SkuProducto = '" + sku + "';";
                return util.ConfigurarConexion("tbProducto", CadenaSQL, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al eliminar productos " + e + "\n");
                return false;
            }
        }
    }
}
