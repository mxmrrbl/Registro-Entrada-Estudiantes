using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Usuario
    {
        D_Usuario d_Usuario = new D_Usuario();
        public List<E_Usuario> ListandoUsuario(string buscar)
        {
            return d_Usuario.ListarUsuario(buscar);
        }

        public void InsertandoUsuario(E_Usuario usuario)
        {
            d_Usuario.InsertarUsuario(usuario);
        }

        public void EditandoUsuario(E_Usuario usuario)
        {
            d_Usuario.EditarUsuario(usuario);
        }

        public void EliminandoUsuario(E_Usuario usuario)
        {
            d_Usuario.EliminarUsuario(usuario);
        }

    }
}
