using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220042.Controller
{
    class cekRegister
    {
        Koneksi Koneksi = new Koneksi();
        public bool cek_register(string username, string password, string confirmpassword)
        {
            try
            {
                Koneksi.OpenConnection();
                MySqlDataReader reader = Koneksi.reader("SELECT * FROM t_register WHERE username='" +
                    username + "' AND password='" + password + "' AND confirmpassword='" + confirmpassword + "'");
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
                MessageBox.Show(e.Message, "Gagal register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
