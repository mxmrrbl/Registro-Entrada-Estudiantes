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
    public class D_Edificio
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-ODMHCFSN; database= REGISTRO_ENTRADA_ESTUDIANTES ; integrated security = true");

        public List<E_Edificio> ListarEdificio(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Edificio> listar = new List<E_Edificio>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Edificio
                {
                    ID_Edificio = leerFilas.GetInt32(0),
                    Nombre_Edificio = leerFilas.GetString(1),
                    
                });

            }

            conexion.Close();
            leerFilas.Close();

            return listar;
        }

        public void InsertarEdificio(E_Edificio edificio)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            
            cmd.Parameters.AddWithValue("@NOMBRE", edificio.Nombre_Edificio);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarEdificio(E_Edificio edificio)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_EDITAR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", edificio.ID_Edificio);
            cmd.Parameters.AddWithValue("@NOMBRE", edificio.Nombre_Edificio);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarEdificio(E_Edificio edificio)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", edificio.ID_Edificio);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
