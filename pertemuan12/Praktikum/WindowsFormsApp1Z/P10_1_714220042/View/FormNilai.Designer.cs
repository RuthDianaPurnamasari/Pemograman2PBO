namespace P10_1_714220042.View
{
    partial class FormNilai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.gBTombolAction = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBdatamahasiswa = new System.Windows.Forms.GroupBox();
            this.tbNilai = new System.Windows.Forms.TextBox();
            this.cbNpm = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbMatkul = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.gBtablemahasiswa = new System.Windows.Forms.GroupBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gBTombolAction.SuspendLayout();
            this.gBdatamahasiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.gBtablemahasiswa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(67, 33);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(253, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(653, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(84, 18);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(182, 21);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(84, 107);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(182, 21);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(84, 77);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(182, 23);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(84, 46);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(182, 23);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // gBTombolAction
            // 
            this.gBTombolAction.Controls.Add(this.btnHapus);
            this.gBTombolAction.Controls.Add(this.btnUbah);
            this.gBTombolAction.Controls.Add(this.btnSimpan);
            this.gBTombolAction.Controls.Add(this.btnRefresh);
            this.gBTombolAction.Location = new System.Drawing.Point(653, 282);
            this.gBTombolAction.Margin = new System.Windows.Forms.Padding(2);
            this.gBTombolAction.Name = "gBTombolAction";
            this.gBTombolAction.Padding = new System.Windows.Forms.Padding(2);
            this.gBTombolAction.Size = new System.Drawing.Size(327, 149);
            this.gBTombolAction.TabIndex = 4;
            this.gBTombolAction.TabStop = false;
            this.gBTombolAction.Text = "Tombol Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // gBdatamahasiswa
            // 
            this.gBdatamahasiswa.Controls.Add(this.tbNama);
            this.gBdatamahasiswa.Controls.Add(this.tbNilai);
            this.gBdatamahasiswa.Controls.Add(this.cbNpm);
            this.gBdatamahasiswa.Controls.Add(this.cbKategori);
            this.gBdatamahasiswa.Controls.Add(this.cbMatkul);
            this.gBdatamahasiswa.Controls.Add(this.label4);
            this.gBdatamahasiswa.Controls.Add(this.label3);
            this.gBdatamahasiswa.Controls.Add(this.label2);
            this.gBdatamahasiswa.Controls.Add(this.label1);
            this.gBdatamahasiswa.Location = new System.Drawing.Point(27, 202);
            this.gBdatamahasiswa.Margin = new System.Windows.Forms.Padding(2);
            this.gBdatamahasiswa.Name = "gBdatamahasiswa";
            this.gBdatamahasiswa.Padding = new System.Windows.Forms.Padding(2);
            this.gBdatamahasiswa.Size = new System.Drawing.Size(591, 229);
            this.gBdatamahasiswa.TabIndex = 5;
            this.gBdatamahasiswa.TabStop = false;
            this.gBdatamahasiswa.Text = "Form Data Mahasiswa";
            // 
            // tbNilai
            // 
            this.tbNilai.Location = new System.Drawing.Point(95, 170);
            this.tbNilai.Name = "tbNilai";
            this.tbNilai.Size = new System.Drawing.Size(231, 20);
            this.tbNilai.TabIndex = 14;
            // 
            // cbNpm
            // 
            this.cbNpm.FormattingEnabled = true;
            this.cbNpm.Location = new System.Drawing.Point(95, 128);
            this.cbNpm.Name = "cbNpm";
            this.cbNpm.Size = new System.Drawing.Size(231, 21);
            this.cbNpm.TabIndex = 13;
            this.cbNpm.SelectedIndexChanged += new System.EventHandler(this.cbNpm_SelectedIndexChanged);
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.cbKategori.Location = new System.Drawing.Point(95, 80);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(231, 21);
            this.cbKategori.TabIndex = 12;
            // 
            // cbMatkul
            // 
            this.cbMatkul.FormattingEnabled = true;
            this.cbMatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman II",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.cbMatkul.Location = new System.Drawing.Point(95, 31);
            this.cbMatkul.Name = "cbMatkul";
            this.cbMatkul.Size = new System.Drawing.Size(231, 21);
            this.cbMatkul.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matkul";
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(0, 16);
            this.DataNilai.Margin = new System.Windows.Forms.Padding(2);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataNilai.RowHeadersWidth = 62;
            this.DataNilai.RowTemplate.Height = 28;
            this.DataNilai.Size = new System.Drawing.Size(953, 115);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick);
            // 
            // gBtablemahasiswa
            // 
            this.gBtablemahasiswa.Controls.Add(this.DataNilai);
            this.gBtablemahasiswa.Location = new System.Drawing.Point(27, 20);
            this.gBtablemahasiswa.Margin = new System.Windows.Forms.Padding(2);
            this.gBtablemahasiswa.Name = "gBtablemahasiswa";
            this.gBtablemahasiswa.Padding = new System.Windows.Forms.Padding(2);
            this.gBtablemahasiswa.Size = new System.Drawing.Size(957, 131);
            this.gBtablemahasiswa.TabIndex = 3;
            this.gBtablemahasiswa.TabStop = false;
            this.gBtablemahasiswa.Text = "Table Data Mahasiswa";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(341, 129);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(231, 20);
            this.tbNama.TabIndex = 15;
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBTombolAction);
            this.Controls.Add(this.gBdatamahasiswa);
            this.Controls.Add(this.gBtablemahasiswa);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBTombolAction.ResumeLayout(false);
            this.gBdatamahasiswa.ResumeLayout(false);
            this.gBdatamahasiswa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.gBtablemahasiswa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox gBTombolAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBdatamahasiswa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataNilai;
        private System.Windows.Forms.GroupBox gBtablemahasiswa;
        private System.Windows.Forms.ComboBox cbNpm;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbMatkul;
        private System.Windows.Forms.TextBox tbNilai;
        private System.Windows.Forms.TextBox tbNama;
    }
}