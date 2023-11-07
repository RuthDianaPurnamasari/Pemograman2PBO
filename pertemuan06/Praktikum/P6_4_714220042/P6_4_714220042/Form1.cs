using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P6_4_714220042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tBnama_Leave_1(object sender, EventArgs e)
        {
            String inputNama = tBnama.Text;
            if (String.IsNullOrEmpty(inputNama))
            {
                epWarning.SetError(tBnama, "Tidak Boleh Kosong!");
                epError.SetError(tBnama, "");
                epCorrect.SetError(tBnama, "");
            }
            else
            {
                if (char.IsUpper(inputNama[0]) && inputNama.Substring(1).All(Char.IsLetter))
                {
                    epWarning.SetError(tBnama, "");
                    epError.SetError(tBnama, "");
                    epCorrect.SetError(tBnama, "Benar!");
                }
                else
                {
                    epWarning.SetError(tBnama, "");
                    epError.SetError(tBnama, "Nama depan diawali huruf kapital dan harus berisi huruf!");
                    epCorrect.SetError(tBnama, "");
                }
            }
        }

        private void tBnamabelakang_Leave(object sender, EventArgs e)
        {
            String inputNama = tBnamabelakang.Text;
            if (String.IsNullOrEmpty(inputNama))
            {
                epWarning.SetError(tBnamabelakang, "Tidak Boleh Kosong!");
                epError.SetError(tBnamabelakang, "");
                epCorrect.SetError(tBnamabelakang, "");
            }
            else
            {
                if (char.IsUpper(inputNama[0]) && inputNama.Substring(1).All(Char.IsLetter))
                {
                    epWarning.SetError(tBnamabelakang, "");
                    epError.SetError(tBnamabelakang, "");
                    epCorrect.SetError(tBnamabelakang, "Benar!");
                }
                else
                {
                    epWarning.SetError(tBnamabelakang, "");
                    epError.SetError(tBnamabelakang, "Harus dimulai huruf kapital dan harus berisi huruf!");
                    epCorrect.SetError(tBnamabelakang, "");
                }
            }
        }

        private void cbJK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tBemail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tBnohp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tBnamaortu_Leave(object sender, EventArgs e)
        {
            if (tBnamaortu.Text == "")
            {
                epWarning.SetError(tBnamaortu, "Tidak Boleh Kosong!");
                epError.SetError(tBnamaortu, "");
                epCorrect.SetError(tBnamaortu, "");
            }
            else
            {
                if ((tBnamaortu.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tBnamaortu, "");
                    epError.SetError(tBnamaortu, "");
                    epCorrect.SetError(tBnamaortu, "Betul!");
                }
                else
                {
                    epWarning.SetError(tBnamaortu, "");
                    epError.SetError(tBnamaortu, "Hanya Inputan Huruf!");
                    epCorrect.SetError(tBnamaortu, "");
                }
            }
        }

        private void tBat_Leave(object sender, EventArgs e)
        {
            if (tBat.Text == "")
            {
                epWarning.SetError(tBat, "Tidak Boleh Kosong!");
                epError.SetError(tBat, "");
                epCorrect.SetError(tBat, "");
            }
            else
            {
                if ((tBat.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tBat, "");
                    epError.SetError(tBat, "");
                    epCorrect.SetError(tBat, "Betul!");
                }
                else
                {
                    epWarning.SetError(tBat, "");
                    epError.SetError(tBat, "Hanya Inputan Huruf!");
                    epCorrect.SetError(tBat, "");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBnama.Text == "")
            {
                MessageBox.Show("Nama harus diisi lengkap!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tBnamabelakang.Text == "")
            {
                MessageBox.Show("Nama harus diisi lengkap!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbJK.Text != "Laki-Laki" && cbJK.Text != "Perempuan" && cbJK.Text != "tidak mau jawab")

            {
                MessageBox.Show("Jenis kelamin tidak valid!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tBemail.Text == "")
            {
                MessageBox.Show("E-mail harus diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tBnohp.Text == "")
            {
                MessageBox.Show("No.Hp harus diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tBnamaortu.Text == "")
            {
                MessageBox.Show("Nama orang tua harus diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tBat.Text == "")
            {
                MessageBox.Show("Alamat Tinggal Harus diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String kelas = "";
            kelas = kelas.TrimEnd(',', ' ');

            if (rb1kids.Checked == true)
            {
                kelas = "Kids Class";
            }
            else if (rb2reguler.Checked == true)
            {
                kelas = "Reguler";
            }
            else if (rb3poomsae.Checked == true)
            {
                kelas = "Poomsae";
            }
            else
            {
                MessageBox.Show("Harus pilih kelas yang diinginkan!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Nama : " + tBnama.Text + tBnamabelakang.Text +
                "\nTanggal lahir : " + dtpTL.Text +
                "\nJenis Kelamin : " + cbJK.Text +
                "\nE-mail : " + tBemail.Text +
                "\nNo.HP :" + tBnohp.Text +
                "\nNama Orang Tua :" + tBnamaortu.Text +
                "\nAlamat Tinggal :" + tBat.Text +
                "\nKelas yang ingin di ikuti :" + kelas,
                "Informasi Formulir Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            return;
        }

        private void tBnohp_Leave(object sender, EventArgs e)
        {
            if (tBnohp.Text == "")
            {
                epWarning.SetError(tBnohp, "Nomor Harus diisi!");
                epError.SetError(tBnohp, "");
                epCorrect.SetError(tBnohp, "");
            }
            else
            {
                if ((tBnohp.Text).All(Char.IsNumber))
                {
                    if (tBnohp.Text.Length >= 12 && tBnohp.Text.Length <= 13)
                    {
                        epWarning.SetError(tBnohp, "");
                        epError.SetError(tBnohp, "");
                        epCorrect.SetError(tBnohp, "Betul!");
                    }
                    else
                    {
                        epWarning.SetError(tBnohp, "No.Hp harus memiliki setidaknya 12 digit!\nMax 13 digit.");
                        epError.SetError(tBnohp, "");
                        epCorrect.SetError(tBnohp, "");
                    }
                }
                else
                {
                    epWarning.SetError(tBnohp, "");
                    epError.SetError(tBnohp, "No.HP tidak valid\nInputan hanya boleh angka.");
                    epCorrect.SetError(tBnohp, "");
                }
            }
        }

        private void tBemail_Leave(object sender, EventArgs e)
        {
            String inputEemail = tBemail.Text;
            if (Regex.IsMatch(tBemail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$") && Char.IsLower(inputEemail[0]))
            {
                epWarning.SetError(tBemail, "");
                epError.SetError(tBemail, "");
                epCorrect.SetError(tBemail, "Betul");
            }
            else
            {
                if (Regex.IsMatch(tBemail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$") && Char.IsUpper(inputEemail[0]))
                {
                    epWarning.SetError(tBemail, "Format Email harus berisikan huruf kecil!\nContoh : a@b.c");
                    epError.SetError(tBemail, "");
                    epCorrect.SetError(tBemail, "");
                }
                else
                {
                    epWarning.SetError(tBemail, "");
                    epError.SetError(tBemail, "Email harus diisi");
                    epCorrect.SetError(tBemail, "");
                }
            }
        }
    }
}
