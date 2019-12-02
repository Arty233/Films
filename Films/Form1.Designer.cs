namespace Films
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
            this.BLoggin = new System.Windows.Forms.Button();
            this.BRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BLoggin
            // 
            this.BLoggin.Location = new System.Drawing.Point(79, 357);
            this.BLoggin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BLoggin.Name = "BLoggin";
            this.BLoggin.Size = new System.Drawing.Size(186, 46);
            this.BLoggin.TabIndex = 0;
            this.BLoggin.Text = "Вход";
            this.BLoggin.UseVisualStyleBackColor = true;
            this.BLoggin.Click += new System.EventHandler(this.BLoggin_Click);
            // 
            // BRegistration
            // 
            this.BRegistration.Location = new System.Drawing.Point(614, 3);
            this.BRegistration.Name = "BRegistration";
            this.BRegistration.Size = new System.Drawing.Size(186, 46);
            this.BRegistration.TabIndex = 1;
            this.BRegistration.Text = "Регистрация";
            this.BRegistration.UseVisualStyleBackColor = true;
            this.BRegistration.Click += new System.EventHandler(this.BRegistration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // TbLogin
            // 
            this.TbLogin.Location = new System.Drawing.Point(79, 83);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(138, 20);
            this.TbLogin.TabIndex = 4;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(79, 215);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(138, 20);
            this.TbPassword.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BRegistration);
            this.Controls.Add(this.BLoggin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLoggin;
        private System.Windows.Forms.Button BRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPassword;
    }
}

