namespace Films
{
    partial class FAddActor
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
            this.BCansel = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BCansel
            // 
            this.BCansel.Location = new System.Drawing.Point(120, 139);
            this.BCansel.Name = "BCansel";
            this.BCansel.Size = new System.Drawing.Size(75, 23);
            this.BCansel.TabIndex = 7;
            this.BCansel.Text = "Отмена";
            this.BCansel.UseVisualStyleBackColor = true;
            this.BCansel.Click += new System.EventHandler(this.BCansel_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(25, 139);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 6;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите имя актёра";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 4;
            // 
            // FAddActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 211);
            this.Controls.Add(this.BCansel);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FAddActor";
            this.Text = "FAddActor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCansel;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}