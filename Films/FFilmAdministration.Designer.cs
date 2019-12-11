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
            this.BAddGenre = new System.Windows.Forms.Button();
            this.BDeleteGenre = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.CbActor = new System.Windows.Forms.ComboBox();
            this.BDeleteActor = new System.Windows.Forms.Button();
            this.BSaveActors = new System.Windows.Forms.Button();
            this.BAddActor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbGenre
            // 
            this.CbGenre.FormattingEnabled = true;
            this.CbGenre.Location = new System.Drawing.Point(20, 31);
            this.CbGenre.Name = "CbGenre";
            this.CbGenre.Size = new System.Drawing.Size(121, 21);
            this.CbGenre.TabIndex = 1;
            // 
            // BAddGenre
            // 
            this.BAddGenre.Location = new System.Drawing.Point(232, 21);
            this.BAddGenre.Name = "BAddGenre";
            this.BAddGenre.Size = new System.Drawing.Size(75, 23);
            this.BAddGenre.TabIndex = 3;
            this.BAddGenre.Text = "Добавить жанр";
            this.BAddGenre.UseVisualStyleBackColor = true;
            this.BAddGenre.Click += new System.EventHandler(this.BAddGenre_Click);
            // 
            // BDeleteGenre
            // 
            this.BDeleteGenre.Location = new System.Drawing.Point(232, 69);
            this.BDeleteGenre.Name = "BDeleteGenre";
            this.BDeleteGenre.Size = new System.Drawing.Size(75, 23);
            this.BDeleteGenre.TabIndex = 4;
            this.BDeleteGenre.Text = "Удалить";
            this.BDeleteGenre.UseVisualStyleBackColor = true;
            this.BDeleteGenre.Click += new System.EventHandler(this.BDeleteGenre_Click);
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(232, 112);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 5;
            this.BSave.Text = "Сохранить";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.CbGenre);
            this.groupBox1.Controls.Add(this.BAddGenre);
            this.groupBox1.Controls.Add(this.BSave);
            this.groupBox1.Controls.Add(this.BDeleteGenre);
            this.groupBox1.Location = new System.Drawing.Point(225, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 203);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Жанры";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.CbActor);
            this.groupBox2.Controls.Add(this.BDeleteActor);
            this.groupBox2.Controls.Add(this.BSaveActors);
            this.groupBox2.Controls.Add(this.BAddActor);
            this.groupBox2.Location = new System.Drawing.Point(225, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 203);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Актёры";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(22, 74);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 13;
            // 
            // CbActor
            // 
            this.CbActor.FormattingEnabled = true;
            this.CbActor.Location = new System.Drawing.Point(21, 34);
            this.CbActor.Name = "CbActor";
            this.CbActor.Size = new System.Drawing.Size(121, 21);
            this.CbActor.TabIndex = 8;
            // 
            // BDeleteActor
            // 
            this.BDeleteActor.Location = new System.Drawing.Point(233, 72);
            this.BDeleteActor.Name = "BDeleteActor";
            this.BDeleteActor.Size = new System.Drawing.Size(75, 23);
            this.BDeleteActor.TabIndex = 10;
            this.BDeleteActor.Text = "Удалить";
            this.BDeleteActor.UseVisualStyleBackColor = true;
            this.BDeleteActor.Click += new System.EventHandler(this.BDeleteActor_Click);
            // 
            // BSaveActors
            // 
            this.BSaveActors.Location = new System.Drawing.Point(233, 115);
            this.BSaveActors.Name = "BSaveActors";
            this.BSaveActors.Size = new System.Drawing.Size(75, 23);
            this.BSaveActors.TabIndex = 11;
            this.BSaveActors.Text = "Сохранить";
            this.BSaveActors.UseVisualStyleBackColor = true;
            this.BSaveActors.Click += new System.EventHandler(this.BSaveActors_Click);
            // 
            // BAddActor
            // 
            this.BAddActor.Location = new System.Drawing.Point(233, 24);
            this.BAddActor.Name = "BAddActor";
            this.BAddActor.Size = new System.Drawing.Size(75, 23);
            this.BAddActor.TabIndex = 9;
            this.BAddActor.Text = "Добавить жанр";
            this.BAddActor.UseVisualStyleBackColor = true;
            this.BAddActor.Click += new System.EventHandler(this.BAddActor_Click);
            // 
            // FFilmAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FFilmAdministration";
            this.Text = "FFilmAdministration";
            this.Load += new System.EventHandler(this.FFilmAdministration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CbGenre;
        private System.Windows.Forms.Button BAddGenre;
        private System.Windows.Forms.Button BDeleteGenre;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox CbActor;
        private System.Windows.Forms.Button BDeleteActor;
        private System.Windows.Forms.Button BSaveActors;
        private System.Windows.Forms.Button BAddActor;
    }
}