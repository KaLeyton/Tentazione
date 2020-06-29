﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDTO;

namespace CapaNegocio
{
    public class NegocioCliente
    {
        //Metodo para listar clientes por columna.
        public DataTable ListaCliente(String filtro, bool sentido)
        {
            try
            {
                Utils util = new Utils();
                return util.ListaUtils(filtro, sentido, "tbCliente");
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
        }

        //Envia un registro de cliente, retorna una confirmacion.
        public bool RegistrarCliente(Cliente cliente)
        {
            try
            {
                Utils utils = new Utils();
                String CadenaSQL = "INSERT INTO tbCliente (tbUsuario_IdUsuario, nombreCompleto,edad,telefono,email,sexo) VALUES ("
                                         + cliente.TbUsuario_IdUsuario + ",'" + cliente.NombreCompleto+ "',"+ cliente.Edad + ","
                                         + cliente.Telefono + ",'" + cliente.Email + "','" + cliente.Sexo + "');";
                //Entrega confirmacion.
                return utils.ConfigurarConexion("tbCliente", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }


        //Metodo para buscar 1 cliente, se entrega un filtro correspondiente a la columa para el Where, y el valor para cerrar la clausula.
        //Selecciona solo el primer resultado.
        public Cliente BuscaCliente(String filtro, String valor)
        {
            Cliente auxCliente = new Cliente();
            try
            {
                Utils util = new Utils();
                DataTable dt = util.ListaUtils(filtro, valor, true, "tbCliente");

                auxCliente.TbUsuario_IdUsuario = (int)dt.Rows[0]["tbUsuario_IdUsuario"];
                auxCliente.NombreCompleto = (String)dt.Rows[0]["NombreCliente"];
                auxCliente.Edad = (int)dt.Rows[0]["Edad"];
                auxCliente.Telefono = (int)dt.Rows[0]["Telefono"];
                auxCliente.Email = (String)dt.Rows[0]["Email"];
                auxCliente.Sexo = (String)dt.Rows[0]["Sexo"];
            }
            catch (Exception e)
            {
                _ = e.Message;
                return null;
            }
            return auxCliente;
        }

        //Insertar metodo que liste varios clientes por filtro.
        //[MEJORA CONTINUA]


        //Actualiza un cliente, seleccionado por id
        public bool ActualizaCliente(Cliente cliente)
        {
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "UPDATE tbCliente SET nombreCompleto = '" + cliente.NombreCompleto + "', Edad = "
                                        + cliente.Edad + ", Telefono = " + cliente.Telefono + ", Email = '"
                                        + cliente.Email + "', Sexo = '" + cliente.Sexo + "' WHERE tbUsuario_IdUsuario = " + cliente.TbUsuario_IdUsuario + ";";
                return util.ConfigurarConexion("tbCliente", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }

        //Elimina un cliente, filtrado por su id
        public bool EliminaCliente(int id)
        {
            try
            {
                Utils util = new Utils();
                String CadenaSQL = "DELETE FROM tbCliente WHERE tbUsuario_IdUsuario = " + id + ";";
                return util.ConfigurarConexion("tbCliente", CadenaSQL, false);
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }
    }
}