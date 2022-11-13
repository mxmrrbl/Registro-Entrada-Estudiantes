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
    public class D_Usuario
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-ODMHCFSN; database= REGISTRO_ENTRADA_ESTUDIANTES ; integrated security = true");

        public List<E_Usuario> ListarUsuario(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Usuario> listar = new List<E_Usuario>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Usuario
                {
                    ID_Usuario = leerFilas.GetInt32(0),
                    Nombre_Usuario = leerFilas.GetString(1),
                    Apellido_Usuario = leerFilas.GetString(2),
                    Fecha_Nacimiento = leerFilas.GetDateTime(3),
                    Usuario = leerFilas.GetString(4),
                    Contraseña = leerFilas.GetString(5),
                    Tipo = leerFilas.GetString(6),
                    
                });

            }

            conexion.Close();
            leerFilas.Close();

            return listar;


        }

        public void InsertarUsuario(E_Usuario usuario)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", usuario.Nombre_Usuario);
            cmd.Parameters.AddWithValue("@APELLIDO", usuario.Apellido_Usuario);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", usuario.Fecha_Nacimiento);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuario.Contraseña);
            cmd.Parameters.AddWithValue("@TIPO", usuario.Tipo);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarUsuario(E_Usuario usuario)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_EDITAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", usuario.ID_Usuario);
            cmd.Parameters.AddWithValue("@NOMBRE", usuario.Nombre_Usuario);
            cmd.Parameters.AddWithValue("@APELLIDO", usuario.Apellido_Usuario);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", usuario.Fecha_Nacimiento);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuario.Contraseña);
            cmd.Parameters.AddWithValue("@TIPO", usuario.Tipo);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarUsuario(E_Usuario usuario)
        {
            conexion.Close();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", usuario.ID_Usuario);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
