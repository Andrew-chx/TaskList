using System;
using System.Configuration;
using System.Data.SqlClient;

namespace TareasApp
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["NombreDeLaConexion"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

/*
 * RESTO DE CODIGO - ABRIR Y CERRAR CONEXION
 * 
 * 
        public static void OpenConnection(SqlConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public static void CloseConnection(SqlConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public static void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = GetConnection())
            {
                OpenConnection(connection);
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                CloseConnection(connection);
            }
        }

        public static SqlDataReader ExecuteReader(string query)
        {
            SqlConnection connection = GetConnection();
            OpenConnection(connection);
            SqlCommand command = new SqlCommand(query, connection);
            return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
    }
}

*/