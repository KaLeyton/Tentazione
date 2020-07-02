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
    public class NegocioCotizacion
    {
        //Trae todas las cotizaciones.
        public DataTable ListaCotizacion(String filtro, bool sentido)
        {
            try
            {
                Utils util = new Utils();
                return util.ListaUtils(filtro, sentido, "tbCotizacion");
            }
            catch (Exception e)
            {
                Console.WriteLine("error, fallo al listar cotizaciones " + e + "\n");
                return null;
            }
        }
        //Envia un registro de Empleado, retorna una confirmacion.
        //Mejora Futuro yo.
        public bool IngresaCotizacion()
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }
    }
}
