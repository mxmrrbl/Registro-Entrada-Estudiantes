using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Edificio
    {
        D_Edificio d_Edificio = new D_Edificio();
        public List<E_Edificio> ListandoEdificio(string buscar)
        {
            return d_Edificio.ListarEdificio(buscar);
        }

        public void InsertandoEdificio(E_Edificio edificio)
        {
            d_Edificio.InsertarEdificio(edificio);
        }

        public void EditandoEdificio(E_Edificio edificio)
        {
            d_Edificio.EditarEdificio(edificio);
        }

        public void EliminandoEdificio(E_Edificio edificio)
        {
            d_Edificio.EliminarEdificio(edificio);
        }
    }
}
