using OryzaTrackDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackBLL
{
    public class DatabaseConnectionBLL
    {
        public bool CekKoneksi(out string errorMsg)
        {
            errorMsg = "";
            try
            {
                DatabaseConnection db = new DatabaseConnection();
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }
    }
}
