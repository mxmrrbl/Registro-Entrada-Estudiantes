using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_Login
    {
        public DataTable Datos;

        SqlConnection conexion = new SqlConnection("server=LAPTOP-ODMHCFSN; database= REGISTRO_ENTRADA_ESTUDIANTES ; integrated security = true");
        public DataTable Ingresar(string usuario, string contraseña)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_VALIDAR_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USUARIO", usuario);
                cmd.Parameters.AddWithValue("@CONTRASEÑA", contraseña);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Datos = dt;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            conexion.Close();
            return Datos;
        }
       
    }
}
