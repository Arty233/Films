using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Films
{
    public partial class FAdministration : Form
    {
        public FAdministration()
        {
            InitializeComponent();
        }

        FilmsContext db = new FilmsContext();
        Film film;
        Genre genre;

        private void FAdministration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmsDataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.filmsDataSet.Genres);
            // TODO: This line of code loads data into the 'filmsDataSet.Films' table. You can move, or remove it, as needed.
            this.filmsTableAdapter.Fill(this.filmsDataSet.Films);       
            DgFilms.DataSource = db.Films.ToList();
        }

       

        private void BRegistration_Click_Click(object sender, EventArgs e)
        {
            FRegistrationAdmin fReg = new FRegistrationAdmin();
            fReg.Show();
        }

        private void DgFilms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BAddFilm_Click(object sender, EventArgs e)
        {
            FAddFilm fAdd = new FAddFilm();
            fAdd.Show();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BChange_Click(object sender, EventArgs e)
        {   
            //string filmToShow = DgFilms.CurrentRow.Cells["filmNameDataGridViewTextBoxColumn"].Value.ToString();
            FFilmAdministration ffa = new FFilmAdministration();
            ffa.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string filmToDelete = DgFilms.CurrentRow.Cells["filmNameDataGridViewTextBoxColumn"].Value.ToString();
            FilmsDB films = new FilmsDB();
            films.DeleteFilm(filmToDelete);
            DgFilms.DataSource = db.Films.ToList();
        }

        private void BAddGenre_Click(object sender, EventArgs e)
        {
            FAddGenre ag = new FAddGenre();
            ag.Show();
            this.Close();
        }

        private void BdeleteGenre_Click(object sender, EventArgs e)
        {
            FilmsDB films = new FilmsDB();
            films.DeleteGenre(LbGenres.Text.ToString());
            
        }
    }
}
