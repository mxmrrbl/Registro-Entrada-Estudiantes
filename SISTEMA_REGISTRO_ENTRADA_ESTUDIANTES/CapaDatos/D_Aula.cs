using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class D_Aula
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-ODMHCFSN; database= REGISTRO_ENTRADA_ESTUDIANTES ; integrated security = true");
        public DataTable DatosE;


        public List<E_Aula> ListarAula(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_AULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Aula> listar = new List<E_Aula>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Aula
                {
                    ID_Aula = leerFilas.GetInt32(0),
                    Edificio_ID = leerFilas.GetInt32(1),
                    Piso_Aula = leerFilas.GetInt32(2),
                    Nombre_Aula = leerFilas.GetString(3),
                    Codigo_Aula = leerFilas.GetString(4)

                });

            }

            conexion.Close();
            leerFilas.Close();

            return listar;


        }

        public void InsertarAula(E_Aula aula)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_AULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_EDIFICIO", aula.Edificio_ID);
            cmd.Parameters.AddWithValue("@PISO", aula.Piso_Aula);
            cmd.Parameters.AddWithValue("@NOMBRE", aula.Nombre_Aula);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarAula(E_Aula aula)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_EDITAR_AULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", aula.ID_Aula);
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", aula.Edificio_ID);
            cmd.Parameters.AddWithValue("@PISO", aula.Piso_Aula);
            cmd.Parameters.AddWithValue("@NOMBRE", aula.Nombre_Aula);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarAula(E_Aula aula)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_AULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", aula.ID_Aula);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public DataTable cargarEdificios()
        {
            SqlCommand cmd = new SqlCommand("SP_CARGAR_EDIFICIOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            conexion.Close();

            DatosE = dt;

            return DatosE;
        }

    }
}
