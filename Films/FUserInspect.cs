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
    public partial class FUserInspect : Form
    {
        FilmsContext db = new FilmsContext();
        public FUserInspect(string name)
        {
            InitializeComponent();
            LFName.Text = name;
            Film film = db.Films.Where(p => (p.FilmName == name)).FirstOrDefault();
            LDescr.Text = film.FilmDescription;
            //
            LData.Text = film.ReleaseDate.ToString().Substring(6, 4);
            //
            string actList = "";
            foreach(var l in film.FilmsActors)
            {
                actList = actList + l.Actor.ActorName + "; ";
            }
            LActors.Text = actList;
            //
            string dirList = "";
            foreach (var l in film.FilmsDirectors)
            {
                dirList = dirList + l.Director.DirectorName + "; ";
            }
            LDirectors.Text = dirList;
        }

        private void FUserInspect_Load(object sender, EventArgs e)
        {
           
        }
    }
}
