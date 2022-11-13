using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Login
    {
        private string _usuario;
        private string _contraseña;

        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
    }


}
