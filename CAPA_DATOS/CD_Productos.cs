using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_Productos
    {
        private CD_Conexion Conexion = new CD_Conexion();

        SqlDataReader reader;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();  

        public DataTable Mostrar()
        {
            command.Connection = Conexion.AbrirConexion();
            command.CommandText = "MostrarProductos";
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            tabla.Load(reader);
            Conexion.CerrarConexion();

            return tabla;
        }

        public void Insertar(string nombre, string desc, string marca, double precio, int stock)
        {
            command.Connection = Conexion.AbrirConexion();
            command.CommandText = "InsertarProductos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@descrip", desc);
            command.Parameters.AddWithValue("@marca", marca);
            command.Parameters.AddWithValue("@precio", precio);
            command.Parameters.AddWithValue("@stock", stock);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
            Conexion.CerrarConexion();
        }

        public void Editar(string nombre, string desc, string marca, double precio, int stock, int id)
        {
            command.Connection = Conexion.AbrirConexion();
            command.CommandText = "EditarProductos";
            command.CommandType= CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@descrip", desc);
            command.Parameters.AddWithValue("@marca", marca);
            command.Parameters.AddWithValue("@precio", precio);
            command.Parameters.AddWithValue("@stock", stock);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
            Conexion.CerrarConexion();


        }

        public void Eliminar(int id)
        {
            command.Connection = Conexion.AbrirConexion();
            command.CommandText = "EliminarProducto";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idProd", id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
            Conexion.CerrarConexion();


        }









    }
}
