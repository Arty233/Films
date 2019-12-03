namespace Films
{
    partial class FAdministration
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
            this.components = new System.ComponentModel.Container();
            this.filmsDataSet = new Films.FilmsDataSet();
            this.filmsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BRegistration = new System.Windows.Forms.Button();
            this.DgFilms = new System.Windows.Forms.DataGridView();
            this.BAddFilm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // filmsDataSet
            // 
            this.filmsDataSet.DataSetName = "FilmsDataSet";
            this.filmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsDataSetBindingSource
            // 
            this.filmsDataSetBindingSource.DataSource = this.filmsDataSet;
            this.filmsDataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(324, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(505, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // BRegistration
            // 
            this.BRegistration.Location = new System.Drawing.Point(12, 12);
            this.BRegistration.Name = "BRegistration";
            this.BRegistration.Size = new System.Drawing.Size(123, 28);
            this.BRegistration.TabIndex = 4;
            this.BRegistration.Text = "Новый админ";
            this.BRegistration.UseVisualStyleBackColor = true;
            this.BRegistration.Click += new System.EventHandler(this.BRegistration_Click_Click);
            // 
            // DgFilms
            // 
            this.DgFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgFilms.Location = new System.Drawing.Point(299, 264);
            this.DgFilms.Name = "DgFilms";
            this.DgFilms.Size = new System.Drawing.Size(407, 150);
            this.DgFilms.TabIndex = 5;
            // 
            // BAddFilm
            // 
            this.BAddFilm.Location = new System.Drawing.Point(13, 59);
            this.BAddFilm.Name = "BAddFilm";
            this.BAddFilm.Size = new System.Drawing.Size(122, 23);
            this.BAddFilm.TabIndex = 6;
            this.BAddFilm.Text = "Добавить фильм";
            this.BAddFilm.UseVisualStyleBackColor = true;
            this.BAddFilm.Click += new System.EventHandler(this.BAddFilm_Click);
            // 
            // FAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BAddFilm);
            this.Controls.Add(this.DgFilms);
            this.Controls.Add(this.BRegistration);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "FAdministration";
            this.Text = "FAdministration";
            this.Load += new System.EventHandler(this.FAdministration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgFilms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource filmsDataSetBindingSource;
        private FilmsDataSet filmsDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BRegistration;
        private System.Windows.Forms.DataGridView DgFilms;
        private System.Windows.Forms.Button BAddFilm;
    }
}