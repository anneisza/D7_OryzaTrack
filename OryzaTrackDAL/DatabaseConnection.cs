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
        public string connectionString =
            "Data Source=RIZA\\RIZAFI;Initial Catalog=OryzaTrack;Integrated Security=True;";


        // get connection
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
