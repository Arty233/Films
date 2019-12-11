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
        
        public FFilmAdministration()
        {
            InitializeComponent();
        }

        FilmsContext db = new FilmsContext();
        Film film;
        Genre genre;
        FilmsGenre filmsGenre;

        private void FFilmAdministration_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.Films.ToList();
            comboBox1.DisplayMember = "FilmName";
            comboBox1.ValueMember = "FilmID";
            CbGenre.DataSource = db.Genres.ToList();
            CbGenre.DisplayMember = "GenreName";
            CbGenre.ValueMember = "GenreID";
            CbActor.DataSource = db.Actors.ToList();
            CbActor.DisplayMember = "ActorName";
            CbActor.ValueMember = "ActorID";
            

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
                listBox1.Items.Add(l.Genre.GenreName);
            };

            listBox2.Items.Clear();
            foreach (var l in film.FilmsActors)
            {
                listBox2.Items.Add(l.Actor.ActorName);
            };
        }

        private void BAddGenre_Click(object sender, EventArgs e)
        {
            Genre genre = (Genre)CbGenre.SelectedItem;
            Film film = (Film)comboBox1.SelectedItem;
            FilmsGenre fg = new FilmsGenre();
            fg.Genre = genre;
            fg.Film = film;
            // Добавляем жанр к фильму
            db.FilmsGenres.Add(fg);
            // и листбоксу
            listBox1.Items.Add(genre.GenreName);
           
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void BDeleteGenre_Click(object sender, EventArgs e)
        {
            Genre genre = (Genre)CbGenre.SelectedItem;
            Film film = (Film)comboBox1.SelectedItem;
            FilmsGenre fg = db.FilmsGenres.Where(p => (p.Film.FilmName == film.FilmName)
                                                    & (p.Genre.GenreName == genre.GenreName)).FirstOrDefault();
            // Очищаем жанры для фильма
            if (fg == null)
            {
                MessageBox.Show("Сначала необходимо сохранить изменения");
                return;
            }
            db.FilmsGenres.Remove(fg);
            // и листбокс
            listBox1.Items.Remove(genre.GenreName);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Выбираем название выделенного элемента
                string s = listBox1.SelectedItem.ToString();
                // Метод where ищет множество объектов по неключевому полю
                // (по названию)
                film.FilmsGenres.Remove
                (db.FilmsGenres.Where(p => p.Genre.GenreName == s).FirstOrDefault());
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BAddActor_Click(object sender, EventArgs e)
        {
            Actor actor = (Actor)CbActor.SelectedItem;
            Film film = (Film)comboBox1.SelectedItem;
            FilmsActor fa = new FilmsActor();
            fa.Actor = actor;
            fa.Film = film;
            // Добавляем жанр к фильму
            db.FilmsActors.Add(fa);
            // и листбоксу
            listBox2.Items.Add(actor.ActorName);
        }

        private void BDeleteActor_Click(object sender, EventArgs e)
        {
            Actor actor = (Actor)CbActor.SelectedItem;
            Film film = (Film)comboBox1.SelectedItem;
            FilmsActor fa = db.FilmsActors.Where(p => (p.Film.FilmName == film.FilmName)
                                                    & (p.Actor.ActorName == actor.ActorName)).FirstOrDefault();
            // Очищаем жанры для фильма
            if (fa == null)
            {
                MessageBox.Show("Сначала необходимо сохранить изменения");
                return;
            }
            db.FilmsActors.Remove(fa);
            // и листбокс
            listBox2.Items.Remove(actor.ActorName);
        }

        private void BSaveActors_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
