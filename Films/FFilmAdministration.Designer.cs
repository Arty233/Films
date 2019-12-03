namespace Films
{
    partial class FFilmAdministration
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
            this.CbGenre = new System.Windows.Forms.ComboBox();
            this.LFilmName = new System.Windows.Forms.Label();
            this.BAddGenre = new System.Windows.Forms.Button();
            this.BDeleteGenre = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CbGenre
            // 
            this.CbGenre.FormattingEnabled = true;
            this.CbGenre.Location = new System.Drawing.Point(200, 109);
            this.CbGenre.Name = "CbGenre";
            this.CbGenre.Size = new System.Drawing.Size(121, 21);
            this.CbGenre.TabIndex = 1;
            // 
            // LFilmName
            // 
            this.LFilmName.AutoSize = true;
            this.LFilmName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LFilmName.Location = new System.Drawing.Point(28, 24);
            this.LFilmName.Name = "LFilmName";
            this.LFilmName.Size = new System.Drawing.Size(71, 23);
            this.LFilmName.TabIndex = 2;
            this.LFilmName.Text = "label1";
            // 
            // BAddGenre
            // 
            this.BAddGenre.Location = new System.Drawing.Point(514, 59);
            this.BAddGenre.Name = "BAddGenre";
            this.BAddGenre.Size = new System.Drawing.Size(75, 23);
            this.BAddGenre.TabIndex = 3;
            this.BAddGenre.Text = "Добавить жанр";
            this.BAddGenre.UseVisualStyleBackColor = true;
            this.BAddGenre.Click += new System.EventHandler(this.BAddGenre_Click);
            // 
            // BDeleteGenre
            // 
            this.BDeleteGenre.Location = new System.Drawing.Point(514, 107);
            this.BDeleteGenre.Name = "BDeleteGenre";
            this.BDeleteGenre.Size = new System.Drawing.Size(75, 23);
            this.BDeleteGenre.TabIndex = 4;
            this.BDeleteGenre.Text = "Удалить";
            this.BDeleteGenre.UseVisualStyleBackColor = true;
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(514, 150);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 5;
            this.BSave.Text = "Сохранить";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(201, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            // 
            // FFilmAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.BDeleteGenre);
            this.Controls.Add(this.BAddGenre);
            this.Controls.Add(this.LFilmName);
            this.Controls.Add(this.CbGenre);
            this.Name = "FFilmAdministration";
            this.Text = "FFilmAdministration";
            this.Load += new System.EventHandler(this.FFilmAdministration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbGenre;
        private System.Windows.Forms.Label LFilmName;
        private System.Windows.Forms.Button BAddGenre;
        private System.Windows.Forms.Button BDeleteGenre;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
    }
}