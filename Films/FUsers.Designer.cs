namespace Films
{
    partial class FUsers
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
            this.DgFilms = new System.Windows.Forms.DataGridView();
            this.filmsDataSet = new Films.FilmsDataSet();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Films.FilmsDataSetTableAdapters.FilmsTableAdapter();
            this.filmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BInspect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.DgFilms.Location = new System.Drawing.Point(12, 57);
            this.DgFilms.Name = "DgFilms";
            this.DgFilms.Size = new System.Drawing.Size(345, 150);
            this.DgFilms.TabIndex = 6;
            // 
            // filmsDataSet
            // 
            this.filmsDataSet.DataSetName = "FilmsDataSet";
            this.filmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.filmsDataSet;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
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
            // BInspect
            // 
            this.BInspect.Location = new System.Drawing.Point(391, 170);
            this.BInspect.Name = "BInspect";
            this.BInspect.Size = new System.Drawing.Size(93, 37);
            this.BInspect.TabIndex = 7;
            this.BInspect.Text = "Подробно";
            this.BInspect.UseVisualStyleBackColor = true;
            this.BInspect.Click += new System.EventHandler(this.BInspect_Click);
            // 
            // FUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BInspect);
            this.Controls.Add(this.DgFilms);
            this.Name = "FUsers";
            this.Text = "FUsers";
            this.Load += new System.EventHandler(this.FUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgFilms;
        private FilmsDataSet filmsDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private FilmsDataSetTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BInspect;
    }
}