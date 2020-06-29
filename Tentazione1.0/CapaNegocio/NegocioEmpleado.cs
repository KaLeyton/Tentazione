using CapaDatos;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioEmpleado
    {
        //Metodo para listar Empleados por columna.
        public DataTable ListaEmpleado(String filtro, bool sentido)
        {
            try
            {
                Utils util = new Utils();
                return util.ListaUtils(filtro, sentido, "tbEmpleado");
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
        }

        //Envia un registro de Empleado, retorna una confirmacion.
        public bool RegistrarEmpleado(Empleado empleado)
        {
            try
            {
                Utils utils = new Utils();
                String CadenaSQL = "INSERT INTO tbEmpleado (tbUsuario_IdUsuario, nombreCompleto,edad,telefono,email,sexo) VALUES ("
                                         + empleado.TbUsuario_IdUsuario + ",'" + empleado.NombreCompleto + "'," + empleado.Edad + ","
                                         + empleado.Telefono + ",'" + empleado.Email + "','" + empleado.Sexo + "');";
                //Entrega confirmacion.
                return utils.ConfigurarConexion("tbEmpleado", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }


        //Metodo para buscar 1 Empleado, se entrega un filtro correspondiente a la columa para el Where, y el valor para cerrar la clausula.
        //Selecciona solo el primer resultado.
        public Empleado BuscaEmpleado(String filtro, String valor)
        {
            Empleado auxEmpleado = new Empleado();
            try
            {
                Utils util = new Utils();
                DataTable dt = util.ListaUtils(filtro, valor, true, "tbEmpleado");

                auxEmpleado.TbUsuario_IdUsuario = (int)dt.Rows[0]["tbUsuario_IdUsuario"];
                auxEmpleado.NombreCompleto = (String)dt.Rows[0]["NombreCompleto"];
                auxEmpleado.Edad = (int)dt.Rows[0]["Edad"];
                auxEmpleado.Telefono = (int)dt.Rows[0]["Telefono"];
                auxEmpleado.Email = (String)dt.Rows[0]["Email"];
                auxEmpleado.Sexo = (String)dt.Rows[0]["Sexo"];
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
            return auxEmpleado;
        }

        //Insertar metodo que liste varios Empleado por filtro.
        //[MEJORA CONTINUA]


        //Actualiza un Empleado, seleccionado por id
        public bool ActualizaEmpleado(Empleado empleado)
        {
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "UPDATE tbEmpleado SET nombreCompleto = '" + empleado.NombreCompleto + "', Edad = "
                                        + empleado.Edad + ", Telefono = " + empleado.Telefono + ", Email = '"
                                        + empleado.Email + "', Sexo = '" + empleado.Sexo + "' WHERE tbUsuario_IdUsuario = " + empleado.TbUsuario_IdUsuario + ";";
                return util.ConfigurarConexion("tbEmpleado", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }

        //Elimina un Empleado, filtrado por su id
        public bool EliminaEmpleado(int id)
        {
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "DELETE FROM tbEmpleado WHERE tbUsuario_IdUsuario = " + id + ";";
                return util.ConfigurarConexion("tbEmpleado", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }
    }
}