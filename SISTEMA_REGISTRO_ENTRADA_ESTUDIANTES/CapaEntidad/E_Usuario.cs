using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuario
    {
        private int _ID_Usuario;
        private string _Nombre_Usuario;
        private string _Apellido_Usuario;
        private DateTime _Fecha_Nacimiento;
        private string _Usuario;
        private string _Contraseña;
        private string _Tipo;

        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public string Nombre_Usuario { get => _Nombre_Usuario; set => _Nombre_Usuario = value; }
        public string Apellido_Usuario { get => _Apellido_Usuario; set => _Apellido_Usuario = value; }
        public DateTime Fecha_Nacimiento { get => _Fecha_Nacimiento; set => _Fecha_Nacimiento = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
    }
}
