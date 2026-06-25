using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace OryzaTrackDAL
{
    public class DatabaseConnection
    {
        // ConnectionString nya
        //public string connectionString =
        //    "Data Source=RIZA\\RIZAFI;Initial Catalog=OryzaTrack;Integrated Security=True;";
        public static string GetLocalIPAddress()
        {
            string localIP = string.Empty;
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting IP: " + ex.Message);
            }
            return localIP;
        }


        // get connection
        public static string GetConnectionString()
        {

            return "Data Source=10.69.1.52,1433;" +
           "Initial Catalog=OryzaTrack;" +
           "User ID=sa;" +
           "Password=anneiszA1.;" +
           "TrustServerCertificate=True;";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
