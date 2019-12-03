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
            this.BRegistration = new System.Windows.Forms.Button();
            this.DgFilms = new System.Windows.Forms.DataGridView();
            this.filmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BAddFilm = new System.Windows.Forms.Button();
            this.filmsTableAdapter = new Films.FilmsDataSetTableAdapters.FilmsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.BChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
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
            this.DgFilms.AutoGenerateColumns = false;
            this.DgFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmNameDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.filmDescriptionDataGridViewTextBoxColumn});
            this.DgFilms.DataSource = this.filmsBindingSource;
            this.DgFilms.Location = new System.Drawing.Point(218, 251);
            this.DgFilms.Name = "DgFilms";
            this.DgFilms.Size = new System.Drawing.Size(465, 150);
            this.DgFilms.TabIndex = 5;
            // 
            // filmNameDataGridViewTextBoxColumn
            // 
            this.filmNameDataGridViewTextBoxColumn.DataPropertyName = "FilmName";
            this.filmNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.filmNameDataGridViewTextBoxColumn.Name = "filmNameDataGridViewTextBoxColumn";
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "Дата выхода";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            // 
            // filmDescriptionDataGridViewTextBoxColumn
            // 
            this.filmDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FilmDescription";
            this.filmDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.filmDescriptionDataGridViewTextBoxColumn.Name = "filmDescriptionDataGridViewTextBoxColumn";
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.filmsDataSetBindingSource;
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
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BChange
            // 
            this.BChange.Location = new System.Drawing.Point(13, 251);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(75, 23);
            this.BChange.TabIndex = 8;
            this.BChange.Text = "Информация";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // FAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAddFilm);
            this.Controls.Add(this.DgFilms);
            this.Controls.Add(this.BRegistration);
            this.Name = "FAdministration";
            this.Text = "FAdministration";
            this.Load += new System.EventHandler(this.FAdministration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource filmsDataSetBindingSource;
        private FilmsDataSet filmsDataSet;
        private System.Windows.Forms.Button BRegistration;
        private System.Windows.Forms.DataGridView DgFilms;
        private System.Windows.Forms.Button BAddFilm;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private FilmsDataSetTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BChange;
    }
}