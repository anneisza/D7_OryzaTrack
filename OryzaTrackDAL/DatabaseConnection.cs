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
        // ConnectionString nya
        private static readonly string connectionString =
            "Data Source=RIZA\\RIZAFI;Initial Catalog=OryzaTrack;Integrated Security=True;";

        private static SqlConnection _connection;

        // get connection
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
