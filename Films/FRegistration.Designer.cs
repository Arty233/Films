namespace Films
{
    partial class FRegistration
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
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbAdmin = new System.Windows.Forms.CheckBox();
            this.BReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(148, 208);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(138, 20);
            this.TbPassword.TabIndex = 9;
            // 
            // TbLogin
            // 
            this.TbLogin.Location = new System.Drawing.Point(148, 76);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(138, 20);
            this.TbLogin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(143, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(143, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин:";
            // 
            // CbAdmin
            // 
            this.CbAdmin.AutoSize = true;
            this.CbAdmin.Location = new System.Drawing.Point(283, 241);
            this.CbAdmin.Name = "CbAdmin";
            this.CbAdmin.Size = new System.Drawing.Size(104, 17);
            this.CbAdmin.TabIndex = 10;
            this.CbAdmin.Text = "Стать админом";
            this.CbAdmin.UseVisualStyleBackColor = true;
            // 
            // BReg
            // 
            this.BReg.Location = new System.Drawing.Point(148, 282);
            this.BReg.Name = "BReg";
            this.BReg.Size = new System.Drawing.Size(134, 33);
            this.BReg.TabIndex = 11;
            this.BReg.Text = "Регистрация";
            this.BReg.UseVisualStyleBackColor = true;
            this.BReg.Click += new System.EventHandler(this.BReg_Click);
            // 
            // FRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 364);
            this.Controls.Add(this.BReg);
            this.Controls.Add(this.CbAdmin);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRegistration";
            this.Text = "FRegistration";
            this.Load += new System.EventHandler(this.FRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CbAdmin;
        private System.Windows.Forms.Button BReg;
    }
}