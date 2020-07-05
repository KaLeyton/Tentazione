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
    public class IntegracionUsuario
    {
        // Entrega nombre y contraseña y retorna un boleanod de confirmacion.
        public bool IRegistrarUsuario(String nombre, String contra)
        {
            NegocioUsuario auxUsuario = new NegocioUsuario();
            return auxUsuario.RegistrarUsuario(nombre,contra);
        }
        // Listara los usuarios mediante columna y sentido para ordear.
        public DataTable IListarUsuario(String filtro, bool sentido)
        {
            NegocioUsuario auxUsuario = new NegocioUsuario();
            return auxUsuario.ListarUsuario(filtro, sentido);
        }
        // Busca un usuario por valor y retorna.
        public Usuario IBuscaUsuario(String filtro, String valor)
        {
            NegocioUsuario auxUsuario = new NegocioUsuario();
            return auxUsuario.BuscaUsuario(filtro, valor);
        }
        // Busca usuario por filtro y valor, retorna string.
        public string IBuscaUsuario(String filtro, String valor, bool esId)
        {
            NegocioUsuario auxUsuario = new NegocioUsuario();
            return auxUsuario.BuscaUsuario(filtro, valor, esId);
        }
        // Actualzia usuario mediante el objeto y retorna una validacion.
        public bool IActualizaUsuario(Usuario usuario)
        {
            NegocioUsuario auxUsuario = new NegocioUsuario();
            return auxUsuario.ActualizaUsuario(usuario);
        }
        // Elimina Usuario y retorna una confirmacion.
        public bool IEliminaUsuario(int id)
        {
            NegocioUsuario auxUsuario = new NegocioUsuario();
            return auxUsuario.EliminaUsuario(id);
        }

    }
}
