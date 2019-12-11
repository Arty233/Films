namespace Films
{
    partial class FUserInspect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUserInspect));
            this.LFName = new System.Windows.Forms.Label();
            this.LDescr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LActors = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LDirectors = new System.Windows.Forms.Label();
            this.LData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LRating = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LFName
            // 
            this.LFName.AutoSize = true;
            this.LFName.Font = new System.Drawing.Font("Palatino Linotype", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LFName.Location = new System.Drawing.Point(12, 219);
            this.LFName.Name = "LFName";
            this.LFName.Size = new System.Drawing.Size(69, 28);
            this.LFName.TabIndex = 0;
            this.LFName.Text = "label1";
            // 
            // LDescr
            // 
            this.LDescr.AutoSize = true;
            this.LDescr.Location = new System.Drawing.Point(17, 314);
            this.LDescr.MaximumSize = new System.Drawing.Size(400, 200);
            this.LDescr.Name = "LDescr";
            this.LDescr.Size = new System.Drawing.Size(35, 13);
            this.LDescr.TabIndex = 1;
            this.LDescr.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(433, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Актёры";
            // 
            // LActors
            // 
            this.LActors.AutoSize = true;
            this.LActors.Location = new System.Drawing.Point(434, 136);
            this.LActors.Name = "LActors";
            this.LActors.Size = new System.Drawing.Size(35, 13);
            this.LActors.TabIndex = 3;
            this.LActors.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(433, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Режиссеры";
            // 
            // LDirectors
            // 
            this.LDirectors.AutoSize = true;
            this.LDirectors.Location = new System.Drawing.Point(437, 329);
            this.LDirectors.Name = "LDirectors";
            this.LDirectors.Size = new System.Drawing.Size(35, 13);
            this.LDirectors.TabIndex = 5;
            this.LDirectors.Text = "label3";
            // 
            // LData
            // 
            this.LData.AutoSize = true;
            this.LData.Location = new System.Drawing.Point(17, 268);
            this.LData.Name = "LData";
            this.LData.Size = new System.Drawing.Size(35, 13);
            this.LData.TabIndex = 6;
            this.LData.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(434, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Рейтинг:";
            // 
            // LRating
            // 
            this.LRating.AutoSize = true;
            this.LRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LRating.Location = new System.Drawing.Point(505, 27);
            this.LRating.Name = "LRating";
            this.LRating.Size = new System.Drawing.Size(46, 17);
            this.LRating.TabIndex = 9;
            this.LRating.Text = "label4";
            // 
            // FUserInspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LData);
            this.Controls.Add(this.LDirectors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LActors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LDescr);
            this.Controls.Add(this.LFName);
            this.Name = "FUserInspect";
            this.Text = "FUserInspect";
            this.Load += new System.EventHandler(this.FUserInspect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFName;
        private System.Windows.Forms.Label LDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LActors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LDirectors;
        private System.Windows.Forms.Label LData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LRating;
    }
}