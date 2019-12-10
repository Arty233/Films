namespace Films
{
    partial class FAddGenre
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BAdd = new System.Windows.Forms.Button();
            this.BCansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название жанра";
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(30, 149);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 2;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BCansel
            // 
            this.BCansel.Location = new System.Drawing.Point(135, 148);
            this.BCansel.Name = "BCansel";
            this.BCansel.Size = new System.Drawing.Size(75, 23);
            this.BCansel.TabIndex = 3;
            this.BCansel.Text = "Отмена";
            this.BCansel.UseVisualStyleBackColor = true;
            this.BCansel.Click += new System.EventHandler(this.BCansel_Click);
            // 
            // FAddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 224);
            this.Controls.Add(this.BCansel);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FAddGenre";
            this.Text = "FAddGenre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BCansel;
    }
}