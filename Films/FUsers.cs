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
    public partial class FUsers : Form
    {
        public FUsers()
        {
            InitializeComponent();
        }

        FilmsContext db = new FilmsContext();
        FilmsDB films = new FilmsDB();

        private void FUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmsDataSet.Films' table. You can move, or remove it, as needed.
            this.filmsTableAdapter.Fill(this.filmsDataSet.Films);

        }

        private void BInspect_Click(object sender, EventArgs e)
        {
            string filmToInspect = DgFilms.CurrentRow.Cells["filmNameDataGridViewTextBoxColumn"].Value.ToString();
            Film film = db.Films.Where(p => (p.FilmName == filmToInspect)).FirstOrDefault();
            film.Popularity++;
            db.SaveChanges();
            FUserInspect ui = new FUserInspect(filmToInspect);
            ui.Show();

        }

        private void BSelectName_Click(object sender, EventArgs e)
        {
            DgFilms.DataSource = films.ShowFilms(TbName.Text);
        }
    }
}
