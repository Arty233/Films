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
            this.filmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsDataSet = new Films.FilmsDataSet();
            this.filmsTableAdapter = new Films.FilmsDataSetTableAdapters.FilmsTableAdapter();
            this.BInspect = new System.Windows.Forms.Button();
            this.TbName = new System.Windows.Forms.TextBox();
            this.BSelectName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).BeginInit();
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
            this.DgFilms.Location = new System.Drawing.Point(12, 97);
            this.DgFilms.Name = "DgFilms";
            this.DgFilms.Size = new System.Drawing.Size(368, 176);
            this.DgFilms.TabIndex = 6;
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
            this.filmsBindingSource.DataSource = this.filmsDataSet;
            // 
            // filmsDataSet
            // 
            this.filmsDataSet.DataSetName = "FilmsDataSet";
            this.filmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // BInspect
            // 
            this.BInspect.Location = new System.Drawing.Point(436, 236);
            this.BInspect.Name = "BInspect";
            this.BInspect.Size = new System.Drawing.Size(93, 37);
            this.BInspect.TabIndex = 7;
            this.BInspect.Text = "Подробно";
            this.BInspect.UseVisualStyleBackColor = true;
            this.BInspect.Click += new System.EventHandler(this.BInspect_Click);
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(99, 14);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(100, 20);
            this.TbName.TabIndex = 8;
            // 
            // BSelectName
            // 
            this.BSelectName.Location = new System.Drawing.Point(224, 12);
            this.BSelectName.Name = "BSelectName";
            this.BSelectName.Size = new System.Drawing.Size(75, 23);
            this.BSelectName.TabIndex = 9;
            this.BSelectName.Text = "Найти";
            this.BSelectName.UseVisualStyleBackColor = true;
            this.BSelectName.Click += new System.EventHandler(this.BSelectName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название:";
            // 
            // FUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BSelectName);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.BInspect);
            this.Controls.Add(this.DgFilms);
            this.Name = "FUsers";
            this.Text = "FUsers";
            this.Load += new System.EventHandler(this.FUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Button BSelectName;
        private System.Windows.Forms.Label label1;
    }
}