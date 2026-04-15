using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace OryzaTrackDAL
{
    public class AdminDAL
    {
        // Login menggunakan ExecuteScalar (sesuai requirement)
        public int Login(string username, string password)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "SELECT idAdmin FROM admin WHERE username=@u AND passwordAdmin=@p";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }
    }
}
