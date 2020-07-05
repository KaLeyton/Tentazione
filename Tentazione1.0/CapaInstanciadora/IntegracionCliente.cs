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
    public class IntegracionCliente
    {
        // Metodo para listar clientes por columna y los ordena de forma ascendiente o descendiente.
        public DataTable IListaCliente(String filtro, bool sentido)
        {
            NegocioCliente auxCLiente = new NegocioCliente();
            return auxCLiente.ListaCliente(filtro,sentido);
        }
        // Registra un cliente y retorna un boleano de confirmacion.
        public bool IRegistrarCliente(Cliente cliente)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.RegistrarCliente(cliente);
        }
        // Metodo Busca cliente por columna y el valor, recibe string.
        public DataTable IBuscaCliente(String filtro, String valor)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.BuscaCliente(filtro,valor);
        }
        // Metodo busca cliente por columna y valor, recibe int.
        public DataTable IBuscaCliente(String filtro, int valor)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.BuscaCliente(filtro, valor);
        }
        // Actualiza un cliente, seleccionado por objeto y retorna un boleanod de confirmacion..
        public bool IActualizaCliente(Cliente cliente)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.ActualizaCliente(cliente);
        }
        // Elimina un cliente segun ID y retorna un boleanod de confirmacion..
        public bool IEliminaCliente(int id)
        {
            NegocioCliente auxCliente = new NegocioCliente();
            return auxCliente.EliminaCliente(id);
        }
    }

}
