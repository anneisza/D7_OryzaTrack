using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackDAL
{
    public class PetaniDAL
    {
        DatabaseConnection db = new DatabaseConnection();

        //View Petani
        public DataTable GetAll()
        {
            //pakai using biar connectionnya langsung close setelah selesai running blok kodenya
            //SqlConnection kayak kabel fisik ke DB
            using (SqlConnection conn = db.GetConnection())
            {
                //buka koneksi sama command buat ngejalanin query
                conn.Open();
                string query = "SELECT * FROM Petani";

                using (SqlCommand cmd = new SqlCommand (query, conn))
                {

                    //eksekusinya pakai SqlDataReader
                    //SqlDataReader "pembaca" dari DB, satu2 per baris smp akhir
                    //ExecuteReader apl ngirim perintah ke DB
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //DataTable: tabel kosong di memori laptop, kek excel
                        DataTable dt = new DataTable();

                        //Ngisi DataTable (yg 'dt' tadi), dari hasil baca SqlDataReader
                        //Mindahin dari db ke DataTable di sini, satu2 per baris smp akhir
                        dt.Load(dr);

                        //habis masuk ke dt, langsung return dt nya ke yg manggil (misalnya dgv)
                        return dt;
                    }

                }
            }
        }
    }
}
