using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;
using CapaNegocio;

namespace CapaInstanciadora
{
    public class IntegracionEmpleado
    {
        // Metodo para listar Empleados por columna.
        public DataTable IListaEmpleado(String filtro, bool sentido)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();
            return auxEmpleado.ListaEmpleado(filtro, sentido);
        }
        // Envia un registro de Empleado, retorna una confirmacion y retorna ua validacion.
        public bool IRegistrarEmpleado(Empleado empleado)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();
            return auxEmpleado.RegistrarEmpleado(empleado);
        }
        // Busca un empleado determinado con columna, filtrando por el valor y retorna una validacion.
        public DataTable IBuscaEmpleado(String filtro, String valor)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();
            return auxEmpleado.BuscaEmpleado(filtro, valor);
        }
        // Actualiza un empleado mediante un objetivo, filtrando por objeto y retorna una validacion.
        public bool IActualizaEmpleado(Empleado empleado)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();
            return auxEmpleado.ActualizaEmpleado(empleado);
        }
        // Elimina un Empleado, filtrado por su id y retorna una validacion.
        public bool IEliminaEmpleado(int id)
        {
            NegocioEmpleado auxEmpleado = new NegocioEmpleado();
            return auxEmpleado.EliminaEmpleado(id);
        }
    }
}
