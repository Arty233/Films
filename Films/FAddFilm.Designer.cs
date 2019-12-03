namespace Films
{
    partial class FAddFilm
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
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbDate = new System.Windows.Forms.TextBox();
            this.TbDescr = new System.Windows.Forms.TextBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(88, 73);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(100, 20);
            this.TbName.TabIndex = 0;
            // 
            // TbDate
            // 
            this.TbDate.Location = new System.Drawing.Point(88, 138);
            this.TbDate.Name = "TbDate";
            this.TbDate.Size = new System.Drawing.Size(100, 20);
            this.TbDate.TabIndex = 1;
            // 
            // TbDescr
            // 
            this.TbDescr.Location = new System.Drawing.Point(88, 209);
            this.TbDescr.Name = "TbDescr";
            this.TbDescr.Size = new System.Drawing.Size(100, 20);
            this.TbDescr.TabIndex = 2;
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(88, 276);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 3;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BCancel
            // 
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(255, 276);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "Отмена";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // FAddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.TbDescr);
            this.Controls.Add(this.TbDate);
            this.Controls.Add(this.TbName);
            this.Name = "FAddFilm";
            this.Text = "FAddFilm";
            this.Load += new System.EventHandler(this.FAddFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbDate;
        private System.Windows.Forms.TextBox TbDescr;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BCancel;
    }
}