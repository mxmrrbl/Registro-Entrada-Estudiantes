using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Entrada
    {
        private int _ID_Entrada;
        private string _Matricula;
        private string nombre_Estudiante;
        private string apellido_Estudiante;
        private string edificio_Nombre;
        private string aula_Codigo;
        private DateTime entrada;
        private DateTime salida;
        private string motivo;

        public int ID_Entrada { get => _ID_Entrada; set => _ID_Entrada = value; }
        public string Matricula { get => _Matricula; set => _Matricula = value; }
        public string Nombre_Estudiante { get => nombre_Estudiante; set => nombre_Estudiante = value; }
        public string Apellido_Estudiante { get => apellido_Estudiante; set => apellido_Estudiante = value; }
        public string Edificio_Nombre { get => edificio_Nombre; set => edificio_Nombre = value; }
        public string Aula_Codigo { get => aula_Codigo; set => aula_Codigo = value; }
        public DateTime Entrada { get => entrada; set => entrada = value; }
        public DateTime Salida { get => salida; set => salida = value; }
        public string Motivo { get => motivo; set => motivo = value; }
    }
}
