using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Aula
    {
        private int _ID_Aula;
        private int _Edificio_ID;
        private int _Piso_Aula;
        private string _Nombre_Aula;
        private string _Codigo_Aula;

        public int ID_Aula { get => _ID_Aula; set => _ID_Aula = value; }
        public int Edificio_ID { get => _Edificio_ID; set => _Edificio_ID = value; }
        public int Piso_Aula { get => _Piso_Aula; set => _Piso_Aula = value; }
        public string Nombre_Aula { get => _Nombre_Aula; set => _Nombre_Aula = value; }
        public string Codigo_Aula { get => _Codigo_Aula; set => _Codigo_Aula = value; }
    }
}
