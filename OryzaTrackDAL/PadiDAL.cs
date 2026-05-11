using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackDAL
{
    public class PadiDAL
    {
        DatabaseConnection db = new DatabaseConnection();

        /*=======================
          View Padi | GetAll()
        ========================*/
        public DataTable GetAll()
        {
            //pakai using biar connectionnya langsung close setelah selesai running blok kodenya
            //SqlConnection kayak kabel fisik ke DB
            using (SqlConnection conn = db.GetConnection())
            {
                //buka koneksi sama command buat ngejalanin query
                conn.Open();
                string query = "SELECT p.idPadi, p.idPetani, pt.namaPetani,  p.jenisBibit,  p.lokasiLahan, p.tanggalTanam FROM padi p JOIN petani pt  ON p.idPetani = pt.idPetani";

                using (SqlCommand cmd = new SqlCommand(query, conn))
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



        /*=======================
                GetById 
         ========================*/
        public DataRow GetById(int idPadi)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM padi WHERE idPadi = @idPadi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        //cek ada data nggak, kalau ada return baris pertama (karena idPetani unik, pasti cuma ada 1 baris), kalau nggak ada return null
                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                        else
                            return null;
                    }
                }
            }
        }

        /*=======================
                Search Padi 
         ========================*/
        public DataTable Search(string keyword)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT 
                    p.idPadi,
                    p.idPetani,
                    pt.namaPetani,
                    p.jenisBibit,
                    p.lokasiLahan,
                    p.tanggalTanam
                FROM padi p
                JOIN petani pt
                    ON p.idPetani = pt.idPetani
                WHERE 
                    CAST(p.idPadi AS VARCHAR) LIKE @keyword
                    OR CAST(p.idPetani AS VARCHAR) LIKE @keyword
                    OR pt.namaPetani LIKE @keyword
                    OR p.jenisBibit LIKE @keyword
                    OR p.lokasiLahan LIKE @keyword
                    OR CONVERT(VARCHAR, p.tanggalTanam, 120) LIKE @keyword";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        return dt;
                    }
                }
            }
        }


        /*=======================
                Insert Padi
         ========================*/
        public bool Insert(string jenisPadi, string lokasiLahan, DateTime tanggalTanam)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO padi 
                                (jenisPadi, lokasiLahan, tanggalTanam) 
                                VALUES 
                                (@jenisPadi, @lokasiLahan, @tanggalTanam)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@jenisPadi", jenisPadi);
                cmd.Parameters.AddWithValue("@lokasiLahan", lokasiLahan);
                cmd.Parameters.AddWithValue("@tanggalTanam", tanggalTanam);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /*=======================
               Update Padi
        ========================*/
        public bool Update(int idPadi, string jenisPadi, string lokasiLahan, DateTime tanggalTanam)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE padi         
                                SET jenisPadi = @jenisPadi, 
                                    lokasiLahan = @lokasiLahan, 
                                    tanggalTanam = @tanggalTanam
                                WHERE idPadi = @idPadi";    
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idPadi", idPadi);
                cmd.Parameters.AddWithValue("@jenisPadi", jenisPadi);
                cmd.Parameters.AddWithValue("@lokasiLahan", lokasiLahan);
                cmd.Parameters.AddWithValue("@tanggalTanam", tanggalTanam);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /*=======================
            Delete Padi
        ========================*/
        public bool Delete(int idPadi)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"DELETE FROM padi WHERE idPadi = @idPadi";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idPadi", idPadi);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /*=======================
                Count Padi 
         ========================*/
        //ExcecuteScalar buat ngejalanin query yang hasilnya cuma satu nilai (misalnya COUNT, SUM, dll)
        public int Count()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM padi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}
