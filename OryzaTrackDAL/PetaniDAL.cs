using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackDAL
{
    public class PetaniDAL
    {
        DatabaseConnection db = new DatabaseConnection();

        /*=======================
          View Petani | GetAll()
        ========================*/
        public DataTable GetAll()
        {
            //pakai using biar connectionnya langsung close setelah selesai running blok kodenya
            //SqlConnection kayak kabel fisik ke DB
            using (SqlConnection conn = db.GetConnection())
            {
                //buka koneksi sama command buat ngejalanin query
                conn.Open();
                string query = "SELECT * FROM Petani";

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
        public DataRow GetById(int idPetani)
        { 
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM petani WHERE idPetani = @idPetani";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPetani", idPetani);
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
                Search Petani 
         ========================*/
        public DataTable Search(string keyword)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT * FROM petani 
                                WHERE namaPetani LIKE @keyword 
                                OR nik LIKE @keyword 
                                OR alamat LIKE @keyword 
                                OR noTelepon LIKE @keyword";
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
                Insert Petani 
         ========================*/
        public bool Insert(string namaPetani, string nik, string alamat, string noTelepon)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO petani 
                                (namaPetani, nik, alamat, noTelepon) 
                                VALUES 
                                (@namaPetani, @nik, @alamat, @noTelepon)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@namaPetani", namaPetani);
                cmd.Parameters.AddWithValue("@nik", nik);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@noTelepon", noTelepon);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /*=======================
               Update Petani 
        ========================*/
        public bool Update(int idPetani, string namaPetani, string nik, string alamat, string noTelepon)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE petani 
                                SET namaPetani = @namaPetani, 
                                    nik = @nik, 
                                    alamat = @alamat, 
                                    noTelepon = @noTelepon
                                WHERE idPetani = @idPetani";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idPetani", idPetani);
                cmd.Parameters.AddWithValue("@namaPetani", namaPetani);
                cmd.Parameters.AddWithValue("@nik", nik);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@noTelepon", noTelepon);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /*=======================
            Delete Petani 
        ========================*/
        public bool Delete(int idPetani)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"DELETE FROM petani WHERE idPetani = @idPetani";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idPetani", idPetani);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /*=======================
                Count Petani 
         ========================*/
        //ExcecuteScalar buat ngejalanin query yang hasilnya cuma satu nilai (misalnya COUNT, SUM, dll)
        public int Count()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM petani";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}
