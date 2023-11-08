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

namespace P7_1_714220042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(540, 226);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCek_Click(object sender, EventArgs e)
        {
            String errorMesseage = "";
            if (string.IsNullOrWhiteSpace(tbNama.Text))
            {
                errorMesseage += "Nama Belum Diisi!\n";
            }
            if (string.IsNullOrWhiteSpace(tbProdi.Text))
            {
                errorMesseage += "Prodi Belum Diisi!\n";
            }
            if(!Regex.IsMatch(tbProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMesseage += "Prodi Harus Berformat [Strata]-[Prodi]\n";
            }else if (string.IsNullOrWhiteSpace(tbKelas.Text))
            {
                errorMesseage += "Kelas Belum Diisi!\n";
            }

            if (string.IsNullOrEmpty(errorMesseage))
            {
                MessageBox.Show(
                    "Lengkap!",
                    "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(750, 635);
            }
            else
            {
                MessageBox.Show(
                    errorMesseage,
                    "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbSenin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSenin.Checked)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = true;
                cbTraveling.Enabled = false; cbTraveling.Checked = false;
                cbTidur.Enabled = true; cbTidur.Checked = true;
            }
        }

        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMinggu.Checked)
            {
                cbKuliah.Enabled = false; cbKuliah.Checked = false;
                cbTraveling.Enabled = true; cbTraveling.Checked = true;
                cbTidur.Enabled = true; cbTidur.Checked = true;
            }
        }

        private void btTutupForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btResetForm_Click(object sender, EventArgs e)
        {
            //tbNama.Text = null;
            //tbProdi.Text = null;
            //tbKelas.Text = null;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = true;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }

            this.Size = new Size(540, 226);
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            String Hari = "";
            String Kegiatan = "";

            if (rbSenin.Checked)
            {
                Hari += "Senin";
            }
            else if (rbMinggu.Checked)
            {
                Hari += "Minggu";
            }

            if (cbTidur.Checked && cbKuliah.Checked)
            {
                Kegiatan += "Kuliah, Tidur";
            }
            else if (cbTraveling.Checked && cbTidur.Checked)
            {
                Kegiatan += "Travelling, Tidur";
            }

            MessageBox.Show("Nama :" + tbNama.Text +
                "\nProdi :" + tbProdi.Text +
                "\nKelas :" + tbKelas.Text +
                "\nHari :" + Hari +
                "\nKegiatan :" + Kegiatan,
                "Informasi Kegiatan",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
