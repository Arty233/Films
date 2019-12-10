﻿namespace Films
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
            this.BChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BAddGenre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BdeleteGenre = new System.Windows.Forms.Button();
            this.LbGenres = new System.Windows.Forms.ListBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresTableAdapter = new Films.FilmsDataSetTableAdapters.GenresTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // BChange
            // 
            this.BChange.Location = new System.Drawing.Point(13, 101);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(122, 23);
            this.BChange.TabIndex = 8;
            this.BChange.Text = "Настроить жанры";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = " Удалить фильм";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BAddGenre
            // 
            this.BAddGenre.Location = new System.Drawing.Point(0, 34);
            this.BAddGenre.Name = "BAddGenre";
            this.BAddGenre.Size = new System.Drawing.Size(123, 23);
            this.BAddGenre.TabIndex = 10;
            this.BAddGenre.Text = "Добавить жанр";
            this.BAddGenre.UseVisualStyleBackColor = true;
            this.BAddGenre.Click += new System.EventHandler(this.BAddGenre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BdeleteGenre);
            this.groupBox1.Controls.Add(this.LbGenres);
            this.groupBox1.Controls.Add(this.BAddGenre);
            this.groupBox1.Location = new System.Drawing.Point(455, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Жанры";
            // 
            // BdeleteGenre
            // 
            this.BdeleteGenre.Location = new System.Drawing.Point(0, 76);
            this.BdeleteGenre.Name = "BdeleteGenre";
            this.BdeleteGenre.Size = new System.Drawing.Size(123, 23);
            this.BdeleteGenre.TabIndex = 12;
            this.BdeleteGenre.Text = "Удалить";
            this.BdeleteGenre.UseVisualStyleBackColor = true;
            this.BdeleteGenre.Click += new System.EventHandler(this.BdeleteGenre_Click);
            // 
            // LbGenres
            // 
            this.LbGenres.DataSource = this.genresBindingSource;
            this.LbGenres.DisplayMember = "GenreName";
            this.LbGenres.FormattingEnabled = true;
            this.LbGenres.Location = new System.Drawing.Point(197, 27);
            this.LbGenres.Name = "LbGenres";
            this.LbGenres.Size = new System.Drawing.Size(120, 95);
            this.LbGenres.TabIndex = 11;
            this.LbGenres.ValueMember = "GenreName";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.filmsDataSetBindingSource;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lBox);
            this.groupBox2.Location = new System.Drawing.Point(189, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 122);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Актёры";
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.Location = new System.Drawing.Point(96, 27);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(120, 95);
            this.lBox.TabIndex = 0;
            // 
            // FAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BChange);
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button BChange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BAddGenre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LbGenres;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private FilmsDataSetTableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.Button BdeleteGenre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lBox;
    }
}