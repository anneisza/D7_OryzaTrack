using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OryzaTrackDAL;



namespace OryzaTrackBLL
{
    public class AdminBLL
    {
        private AdminDAL dal = new AdminDAL();

        public int Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new System.Exception("Username dan password tidak boleh kosong!");
            if (username.Trim().Length < 5)
                throw new Exception("Username minimal harus 5 karakter!");

            if (password.Length < 6)
                throw new Exception("Password minimal harus 6 karakter!");

            return dal.Login(username, password);
        }
    }
}
