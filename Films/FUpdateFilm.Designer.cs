namespace Films
{
    partial class FUpdateFilm
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
            this.label4 = new System.Windows.Forms.Label();
            this.TbImage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.BUpd = new System.Windows.Forms.Button();
            this.TbDescr = new System.Windows.Forms.TextBox();
            this.TbDate = new System.Windows.Forms.TextBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(69, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Название файла с картинкой";
            // 
            // TbImage
            // 
            this.TbImage.Location = new System.Drawing.Point(69, 345);
            this.TbImage.Name = "TbImage";
            this.TbImage.Size = new System.Drawing.Size(219, 20);
            this.TbImage.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(66, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата выхода";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название";
            // 
            // BCancel
            // 
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(236, 399);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 14;
            this.BCancel.Text = "Отмена";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BUpd
            // 
            this.BUpd.Location = new System.Drawing.Point(69, 399);
            this.BUpd.Name = "BUpd";
            this.BUpd.Size = new System.Drawing.Size(75, 23);
            this.BUpd.TabIndex = 13;
            this.BUpd.Text = "Обновить";
            this.BUpd.UseVisualStyleBackColor = true;
            this.BUpd.Click += new System.EventHandler(this.BUpd_Click);
            // 
            // TbDescr
            // 
            this.TbDescr.Location = new System.Drawing.Point(69, 203);
            this.TbDescr.Multiline = true;
            this.TbDescr.Name = "TbDescr";
            this.TbDescr.Size = new System.Drawing.Size(219, 88);
            this.TbDescr.TabIndex = 12;
            // 
            // TbDate
            // 
            this.TbDate.Location = new System.Drawing.Point(69, 138);
            this.TbDate.Name = "TbDate";
            this.TbDate.Size = new System.Drawing.Size(100, 20);
            this.TbDate.TabIndex = 11;
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(69, 56);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(100, 20);
            this.TbName.TabIndex = 10;
            // 
            // FUpdateFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BUpd);
            this.Controls.Add(this.TbDescr);
            this.Controls.Add(this.TbDate);
            this.Controls.Add(this.TbName);
            this.Name = "FUpdateFilm";
            this.Text = "FUpdateFilm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BUpd;
        private System.Windows.Forms.TextBox TbDescr;
        private System.Windows.Forms.TextBox TbDate;
        private System.Windows.Forms.TextBox TbName;
    }
}