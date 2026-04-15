using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OryzaTrackDAL
{
    public class DatabaseConnection
    {
        // Ganti connection string sesuai environment kamu
        private static readonly string connectionString =
            "Server=RIZA\\RIZAFI;Database=OryzaTrack;Integrated Security=True;";

        private static SqlConnection _connection;

        // Koneksi dibuka sekali saat aplikasi start (sesuai requirement)
        public static SqlConnection GetConnection()
        {
            if (_connection == null)
                _connection = new SqlConnection(connectionString);

            if (_connection.State == System.Data.ConnectionState.Closed)
                _connection.Open();

            return _connection;
        }

        public static void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }
}
