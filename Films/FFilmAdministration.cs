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
    public partial class FFilmAdministration : Form
    {
        FilmsContext db = new FilmsContext();
        FilmsDB films = new FilmsDB();
        Film film = new Film();
        public FFilmAdministration(string filmName)
        {       
            InitializeComponent();
            LFilmName.Text = filmName;           
            film = db.Films.Where(p => (p.FilmName == filmName)).FirstOrDefault();
            CbGenre.DataSource = db.Genres.ToList();
            CbGenre.DisplayMember = "GenreName";
            CbGenre.ValueMember = "GenreID";
            listBox1.Items.Clear();
            foreach (var l in film.FilmsGenres)
            {
                listBox1.Items.Add(l.Genre.GenreName);
            };
        }

        private void CbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FFilmAdministration_Load(object sender, EventArgs e)
        {

        }

        private void BAddGenre_Click(object sender, EventArgs e)
        {
            Genre genre = (Genre)CbGenre.SelectedItem;
            Genre newGenre = films.AddGenreToFilm(film, genre);
            listBox1.Items.Add(newGenre.GenreName);
            db.SaveChanges();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
