using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class N_Aula
    {
        public DataTable DatosE;

        D_Aula d_Aula = new D_Aula();
        public List<E_Aula> ListandoAula(string buscar)
        {
            return d_Aula.ListarAula(buscar);
        }

        public void InsertandoAula(E_Aula aula)
        {
            d_Aula.InsertarAula(aula);
        }

        public void EditandoAula(E_Aula aula)
        {
            d_Aula.EditarAula(aula);
        }

        public void EliminandoAula(E_Aula aula)
        {
            d_Aula.EliminarAula(aula);
        }

        public DataTable CargandoEdificios()
        {
            DatosE = d_Aula.cargarEdificios();
            return DatosE;
        }

    }
}
