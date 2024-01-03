namespace P10_1_714220042.View
{
    partial class FormRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMasukUsername = new System.Windows.Forms.TextBox();
            this.tbMasukPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btRegisterNow = new System.Windows.Forms.Button();
            this.btHaveAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masukkan Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // tbMasukUsername
            // 
            this.tbMasukUsername.Location = new System.Drawing.Point(305, 131);
            this.tbMasukUsername.Name = "tbMasukUsername";
            this.tbMasukUsername.Size = new System.Drawing.Size(214, 26);
            this.tbMasukUsername.TabIndex = 4;
            // 
            // tbMasukPassword
            // 
            this.tbMasukPassword.Location = new System.Drawing.Point(305, 181);
            this.tbMasukPassword.Name = "tbMasukPassword";
            this.tbMasukPassword.PasswordChar = '*';
            this.tbMasukPassword.Size = new System.Drawing.Size(214, 26);
            this.tbMasukPassword.TabIndex = 5;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(305, 233);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(214, 26);
            this.tbConfirmPassword.TabIndex = 6;
            // 
            // btRegisterNow
            // 
            this.btRegisterNow.Location = new System.Drawing.Point(346, 286);
            this.btRegisterNow.Name = "btRegisterNow";
            this.btRegisterNow.Size = new System.Drawing.Size(159, 31);
            this.btRegisterNow.TabIndex = 7;
            this.btRegisterNow.Text = "Register Now";
            this.btRegisterNow.UseVisualStyleBackColor = true;
            this.btRegisterNow.Click += new System.EventHandler(this.btRegisterNow_Click);
            // 
            // btHaveAccount
            // 
            this.btHaveAccount.Location = new System.Drawing.Point(287, 333);
            this.btHaveAccount.Name = "btHaveAccount";
            this.btHaveAccount.Size = new System.Drawing.Size(272, 34);
            this.btHaveAccount.TabIndex = 8;
            this.btHaveAccount.Text = "Have Account ? Login Sekarang";
            this.btHaveAccount.UseVisualStyleBackColor = true;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btHaveAccount);
            this.Controls.Add(this.btRegisterNow);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbMasukPassword);
            this.Controls.Add(this.tbMasukUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMasukUsername;
        private System.Windows.Forms.TextBox tbMasukPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button btRegisterNow;
        private System.Windows.Forms.Button btHaveAccount;
    }
}