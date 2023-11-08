namespace P7_1_714220042
{
    partial class Form1
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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbKelas = new System.Windows.Forms.TextBox();
            this.tbProdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCek = new System.Windows.Forms.Button();
            this.btTutupForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKuliah = new System.Windows.Forms.CheckBox();
            this.cbTraveling = new System.Windows.Forms.CheckBox();
            this.cbTidur = new System.Windows.Forms.CheckBox();
            this.rbSenin = new System.Windows.Forms.RadioButton();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.btPrint = new System.Windows.Forms.Button();
            this.btResetForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(309, 34);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(331, 26);
            this.tbNama.TabIndex = 0;
            // 
            // tbKelas
            // 
            this.tbKelas.Location = new System.Drawing.Point(309, 193);
            this.tbKelas.Name = "tbKelas";
            this.tbKelas.Size = new System.Drawing.Size(331, 26);
            this.tbKelas.TabIndex = 1;
            // 
            // tbProdi
            // 
            this.tbProdi.Location = new System.Drawing.Point(309, 106);
            this.tbProdi.Name = "tbProdi";
            this.tbProdi.Size = new System.Drawing.Size(331, 26);
            this.tbProdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kelas";
            // 
            // btCek
            // 
            this.btCek.Location = new System.Drawing.Point(398, 246);
            this.btCek.Name = "btCek";
            this.btCek.Size = new System.Drawing.Size(75, 34);
            this.btCek.TabIndex = 6;
            this.btCek.Text = "Cek";
            this.btCek.UseVisualStyleBackColor = true;
            this.btCek.Click += new System.EventHandler(this.btCek_Click);
            // 
            // btTutupForm
            // 
            this.btTutupForm.Location = new System.Drawing.Point(532, 246);
            this.btTutupForm.Name = "btTutupForm";
            this.btTutupForm.Size = new System.Drawing.Size(108, 34);
            this.btTutupForm.TabIndex = 7;
            this.btTutupForm.Text = "Tutup Form";
            this.btTutupForm.UseVisualStyleBackColor = true;
            this.btTutupForm.Click += new System.EventHandler(this.btTutupForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "LIST KEGIATAN";
            // 
            // cbKuliah
            // 
            this.cbKuliah.AutoSize = true;
            this.cbKuliah.Location = new System.Drawing.Point(49, 448);
            this.cbKuliah.Name = "cbKuliah";
            this.cbKuliah.Size = new System.Drawing.Size(78, 24);
            this.cbKuliah.TabIndex = 9;
            this.cbKuliah.Text = "Kuliah";
            this.cbKuliah.UseVisualStyleBackColor = true;
            // 
            // cbTraveling
            // 
            this.cbTraveling.AutoSize = true;
            this.cbTraveling.Location = new System.Drawing.Point(49, 497);
            this.cbTraveling.Name = "cbTraveling";
            this.cbTraveling.Size = new System.Drawing.Size(98, 24);
            this.cbTraveling.TabIndex = 10;
            this.cbTraveling.Text = "Traveling";
            this.cbTraveling.UseVisualStyleBackColor = true;
            // 
            // cbTidur
            // 
            this.cbTidur.AutoSize = true;
            this.cbTidur.Location = new System.Drawing.Point(49, 544);
            this.cbTidur.Name = "cbTidur";
            this.cbTidur.Size = new System.Drawing.Size(70, 24);
            this.cbTidur.TabIndex = 11;
            this.cbTidur.Text = "Tidur";
            this.cbTidur.UseVisualStyleBackColor = true;
            // 
            // rbSenin
            // 
            this.rbSenin.AutoSize = true;
            this.rbSenin.Location = new System.Drawing.Point(49, 345);
            this.rbSenin.Name = "rbSenin";
            this.rbSenin.Size = new System.Drawing.Size(75, 24);
            this.rbSenin.TabIndex = 12;
            this.rbSenin.TabStop = true;
            this.rbSenin.Text = "Senin";
            this.rbSenin.UseVisualStyleBackColor = true;
            this.rbSenin.CheckedChanged += new System.EventHandler(this.rbSenin_CheckedChanged);
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Location = new System.Drawing.Point(49, 389);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(86, 24);
            this.rbMinggu.TabIndex = 13;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu";
            this.rbMinggu.UseVisualStyleBackColor = true;
            this.rbMinggu.CheckedChanged += new System.EventHandler(this.rbMinggu_CheckedChanged);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(351, 561);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(75, 34);
            this.btPrint.TabIndex = 14;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btResetForm
            // 
            this.btResetForm.Location = new System.Drawing.Point(532, 561);
            this.btResetForm.Name = "btResetForm";
            this.btResetForm.Size = new System.Drawing.Size(108, 34);
            this.btResetForm.TabIndex = 15;
            this.btResetForm.Text = "Reset Form";
            this.btResetForm.UseVisualStyleBackColor = true;
            this.btResetForm.Click += new System.EventHandler(this.btResetForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 589);
            this.Controls.Add(this.btResetForm);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.rbMinggu);
            this.Controls.Add(this.rbSenin);
            this.Controls.Add(this.cbTidur);
            this.Controls.Add(this.cbTraveling);
            this.Controls.Add(this.cbKuliah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btTutupForm);
            this.Controls.Add(this.btCek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProdi);
            this.Controls.Add(this.tbKelas);
            this.Controls.Add(this.tbNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbKelas;
        private System.Windows.Forms.TextBox tbProdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCek;
        private System.Windows.Forms.Button btTutupForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbKuliah;
        private System.Windows.Forms.CheckBox cbTraveling;
        private System.Windows.Forms.CheckBox cbTidur;
        private System.Windows.Forms.RadioButton rbSenin;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btResetForm;
    }
}

