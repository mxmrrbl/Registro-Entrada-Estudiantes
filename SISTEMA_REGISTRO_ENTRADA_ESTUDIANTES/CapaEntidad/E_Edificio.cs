using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Edificio
    {
        private int _ID_Edificio;
        private string _Nombre_Edificio;

        public int ID_Edificio { get => _ID_Edificio; set => _ID_Edificio = value; }
        public string Nombre_Edificio { get => _Nombre_Edificio; set => _Nombre_Edificio = value; }
    }
}
