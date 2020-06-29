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
        //Envia un registro de producto, retorna una confirmacion.
        public bool RegistrarProducto(Producto producto)
        {
            try
            {
                Utils utils = new Utils();
                String CadenaSQL = "INSERT INTO tbProducto (SkuProducto,NombreProducto,Valor,CantPaquete,UnidadMedida) VALUES ('"
                                         + producto.Sku + "','" + producto.NombreProducto + "',"
                                         + producto.Valor + ",'" + producto.CantPaquete + "','" + producto.UnidadMedida + "');";
                //Entrega confirmacion.
                return utils.ConfigurarConexion("tbProducto", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }

        //Metodo para listar productos columna.
        public DataTable ListaProducto(String filtro, bool sentido)
        {
            try
            {
                Utils util = new Utils();
                return util.ListaUtils(filtro, sentido, "tbProducto");
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
        }

        //Metodo para buscar 1 producto, se entrega un filtro correspondiente a la columa para el Where, y el valor para cerrar la clausula.
        //Selecciona solo el primer resultado.
        public Producto BuscaProducto(String filtro, String valor)
        {
            Producto auxProducto = new Producto();
            try
            {
                Utils util = new Utils();
                DataTable dt = util.ListaUtils(filtro, valor, true, "tbProducto");

                auxProducto.Sku = (String)dt.Rows[0]["Sku"];
                auxProducto.NombreProducto = (String)dt.Rows[0]["NombreProducto"];
                auxProducto.Valor = (int)dt.Rows[0]["Valor"];
                auxProducto.CantPaquete = (int)dt.Rows[0]["CantPaquete"];
                auxProducto.UnidadMedida = (String)dt.Rows[0]["UnidadMedida"];
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
            return auxProducto;
        }

        //Insertar metodo que liste varios productos por filtro.
        //[MEJORA CONTINUA]


        //Actualiza un producto, seleccionado por Sku
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
                _ = e.Message;
                return false;
            }
        }

        //Elimina un producto, filtrado por Sku
        public bool EliminaProducto(String sku)
        {
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "DELETE FROM tbProducto WHERE IdProducto = '" + sku + "';";
                return util.ConfigurarConexion("tbProducto", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }
    }
}
