using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

// Esta se empleara para instanciar las capas de negocio y DTO, manteniondo la logica de los WebService para cuando se deba debugear.
// Para esto se debe eliminar la referencia.

namespace CapaInstanciadora
{
    public class IntegracionLogin
    {
        // Devuelve una respuesta sobre si las credenciales son correctas.
        public String IValidaLogIn(String nombre, String contrasena)
        {
            NegocioLogin auxLogin = new NegocioLogin();
            return auxLogin.ValidaLogIn(nombre, contrasena);
        }
        // Devuelve la sesion de los usuarios para manejo de en la capa grafica.
        public String IBuscaSesion()
        {
            NegocioLogin auxLogin = new NegocioLogin();
            return auxLogin.BuscaSesion();
        }
    }
}
