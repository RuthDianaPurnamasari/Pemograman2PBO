using P10_1_714220042.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220042.View
{
    public partial class FormRegister : Form
    {
        cekRegister register = new cekRegister();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btRegisterNow_Click(object sender, EventArgs e)
        {
            if (tbMasukUsername.Text == "" || tbMasukPassword.Text == "")
            {
                MessageBox.Show("Username, Password dan confirm password tidak boleh kosong !!!");
            }
            else
            {
                string username = tbMasukUsername.Text;
                string password = tbMasukPassword.Text;
                string confirmpassword = tbConfirmPassword.Text;

                bool status = register.cek_register(username, password, confirmpassword);
                if (status)
                {
                    MessageBox.Show("Register Berhasil", "Berhasil");
                    ParentForm pfrom = new ParentForm();
                    this.Hide();
                    pfrom.Show();
                }
                else
                {
                    MessageBox.Show("Gagal register", "Gagal");
                }
            }
        }
    }
}
