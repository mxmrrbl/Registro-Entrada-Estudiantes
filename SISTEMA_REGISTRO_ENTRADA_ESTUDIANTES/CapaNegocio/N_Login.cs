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
    public class N_Login
    {
        public DataTable Datos;

        D_Login d_Login  = new D_Login();
        public DataTable Ingresando(string usuario, string contraseña)
        {
           Datos = d_Login.Ingresar(usuario, contraseña);

           return Datos;
        }

    }
}
