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
            comboBox1.DataSource = db.Films.ToList();
            comboBox1.DisplayMember = "FilmName";
            comboBox1.ValueMember = "FilmID";
            comboBox2.DataSource = db.Genres.ToList();
            comboBox2.DisplayMember = "GenreName";
            comboBox2.ValueMember = "GenreID";
            DgFilms.DataSource = db.Films.ToList();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выбираем фильм с помощью комбобокса
            // int idf = (int) comboBox1.SelectedValue;
            // Метод Find ищет объект по ключевому полю idf
            // film = db.Films.Find(idf);
            // Но лучше сразу прочитать сам объект через SelectedItem
            film = (Film)comboBox1.SelectedItem;
            // Заполняем листбокс жанрами выбранного фильма
            listBox1.Items.Clear();
            foreach (var l in film.FilmsGenres)
            {
                listBox1.Items.Add(l.Genre);
            };
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FRegistrationAdmin fReg = new FRegistrationAdmin();
            fReg.Show();
        }
    }
}
