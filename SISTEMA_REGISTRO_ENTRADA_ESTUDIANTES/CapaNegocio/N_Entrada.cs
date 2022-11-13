using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Entrada
    {
        public DataTable DatosE;
        public DataTable DatosA;

        D_Entrada d_Entrada = new D_Entrada();
        public List<E_Entrada> ListandoEntrada(string buscar)
        {
            return d_Entrada.ListarEntrada(buscar);
        }

        public void InsertandoEntrada(E_Entrada entrada)
        {
            d_Entrada.InsertarEntrada(entrada);
        }

        public void EditandoEntrada(E_Entrada entrada)
        {
            d_Entrada.EditarEntrada(entrada);
        }

        public void EliminandoEntrada(E_Entrada entrada)
        {
            d_Entrada.EliminarEntrada(entrada);
        }

        public DataTable CargandoEdificios()
        {
           DatosE = d_Entrada.cargarEdificios();
           return DatosE;
        }

        public DataTable CargandoAulas(int id_Edificio)
        {
            DatosA = d_Entrada.cargarAulas(id_Edificio);
            return DatosA;
        }
    }
}
