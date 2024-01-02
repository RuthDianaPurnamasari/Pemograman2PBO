namespace P10_1_714220042.View
{
    partial class FormTransaksiBarang
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbnamabarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.gBTombolAction = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbtransaksibarang = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataTransaksi = new System.Windows.Forms.DataGridView();
            this.gbTabletransaksibarang = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIDbarang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHargaBarang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gBTombolAction.SuspendLayout();
            this.gbtransaksibarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).BeginInit();
            this.gbTabletransaksibarang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(912, 272);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(490, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(100, 51);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(378, 26);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(126, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(273, 32);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(139, 296);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(299, 26);
            this.tbTotal.TabIndex = 10;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(139, 240);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(299, 26);
            this.tbQuantity.TabIndex = 9;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // tbnamabarang
            // 
            this.tbnamabarang.Location = new System.Drawing.Point(11, 101);
            this.tbnamabarang.Name = "tbnamabarang";
            this.tbnamabarang.Size = new System.Drawing.Size(299, 26);
            this.tbnamabarang.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(126, 165);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(273, 32);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(126, 118);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(273, 35);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(126, 71);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(273, 35);
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
            this.gBTombolAction.Location = new System.Drawing.Point(912, 420);
            this.gBTombolAction.Name = "gBTombolAction";
            this.gBTombolAction.Size = new System.Drawing.Size(490, 229);
            this.gBTombolAction.TabIndex = 4;
            this.gBTombolAction.TabStop = false;
            this.gBTombolAction.Text = "Tombol Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // gbtransaksibarang
            // 
            this.gbtransaksibarang.Controls.Add(this.label9);
            this.gbtransaksibarang.Controls.Add(this.groupBox2);
            this.gbtransaksibarang.Controls.Add(this.tbTotal);
            this.gbtransaksibarang.Controls.Add(this.tbQuantity);
            this.gbtransaksibarang.Controls.Add(this.label6);
            this.gbtransaksibarang.Controls.Add(this.label5);
            this.gbtransaksibarang.Controls.Add(this.label4);
            this.gbtransaksibarang.Controls.Add(this.label1);
            this.gbtransaksibarang.Location = new System.Drawing.Point(46, 292);
            this.gbtransaksibarang.Name = "gbtransaksibarang";
            this.gbtransaksibarang.Size = new System.Drawing.Size(845, 352);
            this.gbtransaksibarang.TabIndex = 5;
            this.gbtransaksibarang.TabStop = false;
            this.gbtransaksibarang.Text = "Form Transaksi Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Barang";
            // 
            // DataTransaksi
            // 
            this.DataTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksi.Location = new System.Drawing.Point(0, 25);
            this.DataTransaksi.Name = "DataTransaksi";
            this.DataTransaksi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataTransaksi.RowHeadersWidth = 62;
            this.DataTransaksi.RowTemplate.Height = 28;
            this.DataTransaksi.Size = new System.Drawing.Size(1338, 177);
            this.DataTransaksi.TabIndex = 0;
            this.DataTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksi_CellClick);
            // 
            // gbTabletransaksibarang
            // 
            this.gbTabletransaksibarang.Controls.Add(this.DataTransaksi);
            this.gbTabletransaksibarang.Location = new System.Drawing.Point(46, 12);
            this.gbTabletransaksibarang.Name = "gbTabletransaksibarang";
            this.gbTabletransaksibarang.Size = new System.Drawing.Size(1344, 202);
            this.gbTabletransaksibarang.TabIndex = 3;
            this.gbTabletransaksibarang.TabStop = false;
            this.gbTabletransaksibarang.Text = "Table Transaksi Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbHargaBarang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbIDbarang);
            this.groupBox2.Controls.Add(this.tbnamabarang);
            this.groupBox2.Location = new System.Drawing.Point(128, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 142);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // cbIDbarang
            // 
            this.cbIDbarang.FormattingEnabled = true;
            this.cbIDbarang.Location = new System.Drawing.Point(11, 23);
            this.cbIDbarang.Name = "cbIDbarang";
            this.cbIDbarang.Size = new System.Drawing.Size(299, 28);
            this.cbIDbarang.TabIndex = 7;
            this.cbIDbarang.SelectedIndexChanged += new System.EventHandler(this.cbIDbarang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Harga Barang";
            // 
            // tbHargaBarang
            // 
            this.tbHargaBarang.Location = new System.Drawing.Point(376, 101);
            this.tbHargaBarang.Name = "tbHargaBarang";
            this.tbHargaBarang.Size = new System.Drawing.Size(299, 26);
            this.tbHargaBarang.TabIndex = 15;
            this.tbHargaBarang.TextChanged += new System.EventHandler(this.tbHargaBarang_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Rp";
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBTombolAction);
            this.Controls.Add(this.gbtransaksibarang);
            this.Controls.Add(this.gbTabletransaksibarang);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBTombolAction.ResumeLayout(false);
            this.gbtransaksibarang.ResumeLayout(false);
            this.gbtransaksibarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).EndInit();
            this.gbTabletransaksibarang.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbnamabarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox gBTombolAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbtransaksibarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataTransaksi;
        private System.Windows.Forms.GroupBox gbTabletransaksibarang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbHargaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIDbarang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}