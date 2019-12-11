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
    public partial class FUpdateFilm : Form
    {
        FilmsDB films = new FilmsDB();
        FilmsContext db = new FilmsContext();
        Film film;
        public FUpdateFilm(string filmToUpdate)
        {
            InitializeComponent();
            film = db.Films.Where(p => (p.FilmName == filmToUpdate)).FirstOrDefault();
            TbName.Text = film.FilmName;
            TbDate.Text = film.ReleaseDate.ToString().Substring(0,10);
            TbDescr.Text = film.FilmDescription;
            TbImage.Text = film.Image;
        }

        private void BUpd_Click(object sender, EventArgs e)
        {
            {
                if (TbName.Text.Length == 0)
                {
                    MessageBox.Show("Name can't be empty");
                    return;
                }
                DateTime data;
                if (!DateTime.TryParse(TbDate.Text, out data))
                {
                    MessageBox.Show("Wrong data");
                    return;
                }
                if (films.UpdateFilm(film.FilmName, TbName.Text, data, TbDescr.Text, TbImage.Text))
                {
                    MessageBox.Show("Data was updated");
                    FAdministration fAdministration = new FAdministration();
                    fAdministration.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Update Error!");
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            FAdministration fAdministration = new FAdministration();
            fAdministration.Show();
            this.Close();
        }
    }
}
