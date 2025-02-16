﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Films
{
    public partial class FUserInspect : Form
    {
        const string IMAGE_PATH = "C:\\РПБД\\Films\\Images\\";
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
            foreach (var l in film.FilmsActors)
            {
                actList = actList + l.Actor.ActorName + "; ";
            }
            if (actList.Length > 2)
                LActors.Text = actList.Substring(0, actList.Length - 2);
            else
            {
                LActors.Text = "Нет информации об актёрах";
            }
            //
            string dirList = "";
            foreach (var l in film.FilmsDirectors)
            {
                dirList = dirList + l.Director.DirectorName + "; ";
            }
            if (dirList.Length > 2)
                LDirectors.Text = dirList.Substring(0, dirList.Length - 2);
            else
            {
                LDirectors.Text = "Нет информации о режиссерах";
            }
            //
            if (film.Image != null & File.Exists(IMAGE_PATH + film.Image))
                pictureBox1.ImageLocation = IMAGE_PATH + film.Image;
            //
            LRating.Text = Convert.ToString(film.Popularity);
        }

        private void FUserInspect_Load(object sender, EventArgs e)
        {

        }


    }
}
