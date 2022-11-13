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
    public class D_Entrada
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-ODMHCFSN; database= REGISTRO_ENTRADA_ESTUDIANTES ; integrated security = true");
        public DataTable DatosE;
        public DataTable DatosA;
        public List<E_Entrada> ListarEntrada(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_ENTRADA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Entrada> listar = new List<E_Entrada>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Entrada
                {
                    ID_Entrada = leerFilas.GetInt32(0),
                    Matricula = leerFilas.GetString(1),
                    Nombre_Estudiante = leerFilas.GetString(2),
                    Apellido_Estudiante = leerFilas.GetString(3),
                    Edificio_Nombre = leerFilas.GetString(4),
                    Aula_Codigo = leerFilas.GetString(5),
                    Entrada = leerFilas.GetDateTime(6),
                    Salida = leerFilas.GetDateTime(7),
                    Motivo = leerFilas.GetString(8)

                });

            }

            conexion.Close();
            leerFilas.Close();

            return listar;


        }

        public void InsertarEntrada(E_Entrada entrada)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_ENTRADA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@MATRICULA", entrada.Matricula);
            cmd.Parameters.AddWithValue("@NOMBRE", entrada.Nombre_Estudiante);
            cmd.Parameters.AddWithValue("@APELLIDO", entrada.Apellido_Estudiante);
            cmd.Parameters.AddWithValue("@EDIFICIO", entrada.Edificio_Nombre);
            cmd.Parameters.AddWithValue("@AULA", entrada.Aula_Codigo);
            cmd.Parameters.AddWithValue("@ENTRADA", entrada.Entrada);
            cmd.Parameters.AddWithValue("@SALIDA", entrada.Salida);
            cmd.Parameters.AddWithValue("@MOTIVO", entrada.Motivo);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarEntrada(E_Entrada entrada)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_EDITAR_ENTRADA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", entrada.ID_Entrada);
            cmd.Parameters.AddWithValue("@MATRICULA", entrada.Matricula);
            cmd.Parameters.AddWithValue("@NOMBRE", entrada.Nombre_Estudiante);
            cmd.Parameters.AddWithValue("@APELLIDO", entrada.Apellido_Estudiante);
            cmd.Parameters.AddWithValue("@EDIFICIO", entrada.Edificio_Nombre);
            cmd.Parameters.AddWithValue("@AULA", entrada.Aula_Codigo);
            cmd.Parameters.AddWithValue("@ENTRADA", entrada.Entrada);
            cmd.Parameters.AddWithValue("@SALIDA", entrada.Salida);
            cmd.Parameters.AddWithValue("@MOTIVO", entrada.Motivo);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarEntrada(E_Entrada entrada)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_ENTRADAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", entrada.ID_Entrada);


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

        public DataTable cargarAulas(int id_Edificio)
        {
            SqlCommand cmd = new SqlCommand("SP_CARGAR_AULAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", id_Edificio);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DatosA = dt;

            return DatosA;
        }

    }
}
