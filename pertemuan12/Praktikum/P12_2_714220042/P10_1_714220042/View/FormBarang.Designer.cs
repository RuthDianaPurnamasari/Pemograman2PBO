namespace P10_1_714220042.View
{
    partial class FormBarang
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
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.gBTombolAction = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbinputbarang = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataBarang = new System.Windows.Forms.DataGridView();
            this.gbTabeldatabarang = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gBTombolAction.SuspendLayout();
            this.gbinputbarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).BeginInit();
            this.gbTabeldatabarang.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(59, 444);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(578, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(100, 51);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(450, 26);
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
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(142, 86);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(416, 26);
            this.tbHarga.TabIndex = 7;
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(142, 45);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(416, 26);
            this.tbNamaBarang.TabIndex = 6;
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
            this.gBTombolAction.Location = new System.Drawing.Point(757, 292);
            this.gBTombolAction.Name = "gBTombolAction";
            this.gBTombolAction.Size = new System.Drawing.Size(490, 229);
            this.gBTombolAction.TabIndex = 4;
            this.gBTombolAction.TabStop = false;
            this.gBTombolAction.Text = "Tombol Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga";
            // 
            // gbinputbarang
            // 
            this.gbinputbarang.Controls.Add(this.tbHarga);
            this.gbinputbarang.Controls.Add(this.tbNamaBarang);
            this.gbinputbarang.Controls.Add(this.label2);
            this.gbinputbarang.Controls.Add(this.label1);
            this.gbinputbarang.Location = new System.Drawing.Point(53, 285);
            this.gbinputbarang.Name = "gbinputbarang";
            this.gbinputbarang.Size = new System.Drawing.Size(584, 141);
            this.gbinputbarang.TabIndex = 5;
            this.gbinputbarang.TabStop = false;
            this.gbinputbarang.Text = "Form Input Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // DataBarang
            // 
            this.DataBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBarang.Location = new System.Drawing.Point(6, 19);
            this.DataBarang.Name = "DataBarang";
            this.DataBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataBarang.RowHeadersWidth = 62;
            this.DataBarang.RowTemplate.Height = 28;
            this.DataBarang.Size = new System.Drawing.Size(1182, 177);
            this.DataBarang.TabIndex = 0;
            this.DataBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellClick);
            // 
            // gbTabeldatabarang
            // 
            this.gbTabeldatabarang.Controls.Add(this.DataBarang);
            this.gbTabeldatabarang.Location = new System.Drawing.Point(53, 31);
            this.gbTabeldatabarang.Name = "gbTabeldatabarang";
            this.gbTabeldatabarang.Size = new System.Drawing.Size(1194, 202);
            this.gbTabeldatabarang.TabIndex = 3;
            this.gbTabeldatabarang.TabStop = false;
            this.gbTabeldatabarang.Text = "Table Data Barang";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBTombolAction);
            this.Controls.Add(this.gbinputbarang);
            this.Controls.Add(this.gbTabeldatabarang);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBTombolAction.ResumeLayout(false);
            this.gbinputbarang.ResumeLayout(false);
            this.gbinputbarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).EndInit();
            this.gbTabeldatabarang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox gBTombolAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbinputbarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataBarang;
        private System.Windows.Forms.GroupBox gbTabeldatabarang;
    }
}