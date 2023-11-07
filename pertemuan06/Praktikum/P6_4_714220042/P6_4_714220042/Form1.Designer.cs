using System;

namespace P6_4_714220042
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelfrom = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.Label();
            this.tb6 = new System.Windows.Forms.Label();
            this.tb7 = new System.Windows.Forms.Label();
            this.tbKelas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tBnama = new System.Windows.Forms.TextBox();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.dtpTL = new System.Windows.Forms.DateTimePicker();
            this.tBemail = new System.Windows.Forms.TextBox();
            this.tBnohp = new System.Windows.Forms.TextBox();
            this.tBnamaortu = new System.Windows.Forms.TextBox();
            this.tBat = new System.Windows.Forms.TextBox();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.rb1kids = new System.Windows.Forms.RadioButton();
            this.rb2reguler = new System.Windows.Forms.RadioButton();
            this.rb3poomsae = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tBnamabelakang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelfrom
            // 
            this.labelfrom.AutoSize = true;
            this.labelfrom.BackColor = System.Drawing.Color.White;
            this.labelfrom.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfrom.ForeColor = System.Drawing.Color.DarkRed;
            this.labelfrom.Location = new System.Drawing.Point(55, 9);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(695, 25);
            this.labelfrom.TabIndex = 0;
            this.labelfrom.Text = "FORMULIR PENDAFTARAN ANGGOTA BARU TAEKWONDO";
            // 
            // tb1
            // 
            this.tb1.AutoSize = true;
            this.tb1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.ForeColor = System.Drawing.Color.Maroon;
            this.tb1.Location = new System.Drawing.Point(59, 50);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(186, 25);
            this.tb1.TabIndex = 1;
            this.tb1.Text = "Nama Depan       :";
            this.tb1.Leave += new System.EventHandler(this.tBnama_Leave);
            // 
            // tb2
            // 
            this.tb2.AutoSize = true;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.ForeColor = System.Drawing.Color.Maroon;
            this.tb2.Location = new System.Drawing.Point(56, 124);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(187, 25);
            this.tb2.TabIndex = 2;
            this.tb2.Text = "Tanggal lahir       :";
            // 
            // tb3
            // 
            this.tb3.AutoSize = true;
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.ForeColor = System.Drawing.Color.Maroon;
            this.tb3.Location = new System.Drawing.Point(52, 172);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(191, 25);
            this.tb3.TabIndex = 3;
            this.tb3.Text = "Jenis Kelamin      :";
            // 
            // tb4
            // 
            this.tb4.AutoSize = true;
            this.tb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4.ForeColor = System.Drawing.Color.Maroon;
            this.tb4.Location = new System.Drawing.Point(55, 219);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(182, 25);
            this.tb4.TabIndex = 4;
            this.tb4.Text = "E-mail                 :";
            // 
            // tb5
            // 
            this.tb5.AutoSize = true;
            this.tb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb5.ForeColor = System.Drawing.Color.Maroon;
            this.tb5.Location = new System.Drawing.Point(56, 266);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(183, 25);
            this.tb5.TabIndex = 5;
            this.tb5.Text = "No. HP                :";
            // 
            // tb6
            // 
            this.tb6.AutoSize = true;
            this.tb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.ForeColor = System.Drawing.Color.Maroon;
            this.tb6.Location = new System.Drawing.Point(54, 313);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(191, 25);
            this.tb6.TabIndex = 6;
            this.tb6.Text = "Nama Orang Tua :";
            // 
            // tb7
            // 
            this.tb7.AutoSize = true;
            this.tb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb7.ForeColor = System.Drawing.Color.Maroon;
            this.tb7.Location = new System.Drawing.Point(56, 365);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(188, 25);
            this.tb7.TabIndex = 7;
            this.tb7.Text = "Alamat Tinggal    :";
            // 
            // tbKelas
            // 
            this.tbKelas.AutoSize = true;
            this.tbKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKelas.ForeColor = System.Drawing.Color.Maroon;
            this.tbKelas.Location = new System.Drawing.Point(44, 409);
            this.tbKelas.Name = "tbKelas";
            this.tbKelas.Size = new System.Drawing.Size(265, 25);
            this.tbKelas.TabIndex = 8;
            this.tbKelas.Text = "Kelas yang ingin di ikuti   :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(647, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "DAFTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBnama
            // 
            this.tBnama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tBnama.Location = new System.Drawing.Point(363, 50);
            this.tBnama.Name = "tBnama";
            this.tBnama.Size = new System.Drawing.Size(262, 26);
            this.tBnama.TabIndex = 13;
            this.tBnama.Leave += new System.EventHandler(this.tBnama_Leave_1);
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan",
            "tidak mau jawab"});
            this.cbJK.Location = new System.Drawing.Point(365, 169);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(260, 28);
            this.cbJK.TabIndex = 14;
            this.cbJK.SelectedIndexChanged += new System.EventHandler(this.cbJK_SelectedIndexChanged);
            // 
            // dtpTL
            // 
            this.dtpTL.Location = new System.Drawing.Point(365, 123);
            this.dtpTL.Name = "dtpTL";
            this.dtpTL.Size = new System.Drawing.Size(260, 26);
            this.dtpTL.TabIndex = 15;
            // 
            // tBemail
            // 
            this.tBemail.Location = new System.Drawing.Point(365, 219);
            this.tBemail.Name = "tBemail";
            this.tBemail.Size = new System.Drawing.Size(260, 26);
            this.tBemail.TabIndex = 16;
            this.tBemail.TextChanged += new System.EventHandler(this.tBemail_TextChanged);
            this.tBemail.Leave += new System.EventHandler(this.tBemail_Leave);
            // 
            // tBnohp
            // 
            this.tBnohp.Location = new System.Drawing.Point(363, 265);
            this.tBnohp.Name = "tBnohp";
            this.tBnohp.Size = new System.Drawing.Size(262, 26);
            this.tBnohp.TabIndex = 17;
            this.tBnohp.TextChanged += new System.EventHandler(this.tBnohp_TextChanged);
            this.tBnohp.Leave += new System.EventHandler(this.tBnohp_Leave);
            // 
            // tBnamaortu
            // 
            this.tBnamaortu.Location = new System.Drawing.Point(363, 313);
            this.tBnamaortu.Name = "tBnamaortu";
            this.tBnamaortu.Size = new System.Drawing.Size(262, 26);
            this.tBnamaortu.TabIndex = 18;
            this.tBnamaortu.Leave += new System.EventHandler(this.tBnamaortu_Leave);
            // 
            // tBat
            // 
            this.tBat.Location = new System.Drawing.Point(363, 364);
            this.tBat.Name = "tBat";
            this.tBat.Size = new System.Drawing.Size(262, 26);
            this.tBat.TabIndex = 19;
            this.tBat.Leave += new System.EventHandler(this.tBat_Leave);
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            this.epError.Icon = ((System.Drawing.Icon)(resources.GetObject("epError.Icon")));
            // 
            // rb1kids
            // 
            this.rb1kids.AutoSize = true;
            this.rb1kids.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1kids.ForeColor = System.Drawing.Color.Maroon;
            this.rb1kids.Location = new System.Drawing.Point(46, 456);
            this.rb1kids.Name = "rb1kids";
            this.rb1kids.Size = new System.Drawing.Size(117, 24);
            this.rb1kids.TabIndex = 20;
            this.rb1kids.TabStop = true;
            this.rb1kids.Text = "Kids Class";
            this.rb1kids.UseVisualStyleBackColor = true;
            // 
            // rb2reguler
            // 
            this.rb2reguler.AutoSize = true;
            this.rb2reguler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2reguler.ForeColor = System.Drawing.Color.Maroon;
            this.rb2reguler.Location = new System.Drawing.Point(225, 456);
            this.rb2reguler.Name = "rb2reguler";
            this.rb2reguler.Size = new System.Drawing.Size(97, 24);
            this.rb2reguler.TabIndex = 21;
            this.rb2reguler.TabStop = true;
            this.rb2reguler.Text = "Reguler";
            this.rb2reguler.UseVisualStyleBackColor = true;
            // 
            // rb3poomsae
            // 
            this.rb3poomsae.AutoSize = true;
            this.rb3poomsae.BackColor = System.Drawing.SystemColors.Window;
            this.rb3poomsae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3poomsae.ForeColor = System.Drawing.Color.Maroon;
            this.rb3poomsae.Location = new System.Drawing.Point(393, 456);
            this.rb3poomsae.Name = "rb3poomsae";
            this.rb3poomsae.Size = new System.Drawing.Size(108, 24);
            this.rb3poomsae.TabIndex = 22;
            this.rb3poomsae.TabStop = true;
            this.rb3poomsae.Text = "Poomsae";
            this.rb3poomsae.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(56, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nama Belakang   :";
            // 
            // tBnamabelakang
            // 
            this.tBnamabelakang.Location = new System.Drawing.Point(365, 86);
            this.tBnamabelakang.Name = "tBnamabelakang";
            this.tBnamabelakang.Size = new System.Drawing.Size(260, 26);
            this.tBnamabelakang.TabIndex = 24;
            this.tBnamabelakang.Leave += new System.EventHandler(this.tBnamabelakang_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.tBnamabelakang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb3poomsae);
            this.Controls.Add(this.rb2reguler);
            this.Controls.Add(this.rb1kids);
            this.Controls.Add(this.tBat);
            this.Controls.Add(this.tBnamaortu);
            this.Controls.Add(this.tBnohp);
            this.Controls.Add(this.tBemail);
            this.Controls.Add(this.dtpTL);
            this.Controls.Add(this.cbJK);
            this.Controls.Add(this.tBnama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbKelas);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.labelfrom);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tBnama_Leave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label labelfrom;
        private System.Windows.Forms.Label tb1;
        private System.Windows.Forms.Label tb2;
        private System.Windows.Forms.Label tb3;
        private System.Windows.Forms.Label tb4;
        private System.Windows.Forms.Label tb5;
        private System.Windows.Forms.Label tb6;
        private System.Windows.Forms.Label tb7;
        private System.Windows.Forms.Label tbKelas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBnama;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.DateTimePicker dtpTL;
        private System.Windows.Forms.TextBox tBemail;
        private System.Windows.Forms.TextBox tBnohp;
        private System.Windows.Forms.TextBox tBnamaortu;
        private System.Windows.Forms.TextBox tBat;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.RadioButton rb3poomsae;
        private System.Windows.Forms.RadioButton rb2reguler;
        private System.Windows.Forms.RadioButton rb1kids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBnamabelakang;
    }
}


