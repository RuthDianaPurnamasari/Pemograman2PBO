using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220042.Controller
{
    class CekLogin
    {
        Koneksi Koneksi = new Koneksi();

        public bool cek_login(string username, string password)
        {
            try
            {
                Koneksi.OpenConnection();
                MySqlDataReader reader = Koneksi.reader("SELECT * FROM t_user WHERE username='" +
                    username + "' AND password='" + password + "'");
                if (reader.Read())
                {
                    Koneksi.CloseConnection();
                    return true;
                }
                else
                {
                    Koneksi.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
