using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    class FilmsDB
    {
        FilmsContext db;
       
        public FilmsDB()
        {
            db = new FilmsContext();
        }

        public User NewUser(string log, string pass, Boolean isAdmin)
        {
            int id = 1;
            User us;
            while (true)
            {
                us = db.Users.Where(p => (p.UserID == id)).FirstOrDefault();
                if (us != null)
                {
                    id++;
                    us = null;
                }
                else
                    break;
            }
            us = db.Users.Where(p => (p.UserName == log)).FirstOrDefault();
            if (us != null)
            {
                return null;
            }
            else
            {
                if ((log != "") && (pass != ""))
                {
                    User t = new User();
                    t.UserID = id;
                    t.UserName = log;
                    t.Password = pass;
                    t.IsAdmin = isAdmin;
                    db.Users.Add(t);
                    db.SaveChanges();
                    return t;
                }
                else
                {
                    return null;
                }
            }

        }

        public int Authorisation(string log, string pass)
        {
            User us = db.Users.Where(p => ((p.UserName == log) && (p.Password == pass))).FirstOrDefault();
            if (us != null)
            {
                return Convert.ToInt32(us.IsAdmin);
            }
            else
                return -1;
        }

        public Film NewFilm(string name, DateTime? relDate, string descr)
        {
            Film film = db.Films.Where(p => (p.FilmName == name)).FirstOrDefault();
            if (film != null)
            {
                return null;
            }
            else
            {
                Film t = new Film();
                t.FilmName = name;
                t.FilmDescription = descr;
                t.ReleaseDate = relDate;
                db.Films.Add(t);
                db.SaveChanges();
                return t;
            }
        }

        public void DeleteFilm(string name)
        {
            Film film = db.Films.Where(p => (p.FilmName == name)).FirstOrDefault();
            FilmsGenre fg = db.FilmsGenres.Where(p => (p.Film.FilmName == name)).FirstOrDefault();
            while (fg != null)
            {
                db.FilmsGenres.Remove(fg);
                db.SaveChanges();
                fg = db.FilmsGenres.Where(p => (p.Film.FilmName == name)).FirstOrDefault();
            }
            db.Films.Remove(film);
            db.SaveChanges();
        }

        public Genre NewGenre(string name)
        {
            Genre genre = db.Genres.Where(p => (p.GenreName == name)).FirstOrDefault();
            if (genre != null)
            {
                return null;
            }
            else
            {
                Genre t = new Genre();
                t.GenreName = name;                
                db.Genres.Add(t);
                db.SaveChanges();
                return t;
            }
        }

        public void DeleteGenre(string name)
        {
            Genre genre = db.Genres.Where(p => (p.GenreName == name)).FirstOrDefault();
            FilmsGenre fg = db.FilmsGenres.Where(p => (p.Genre.GenreName == name)).FirstOrDefault();
            while (fg != null)
            {
                db.FilmsGenres.Remove(fg);
                db.SaveChanges();
                fg = db.FilmsGenres.Where(p => (p.Genre.GenreName == name)).FirstOrDefault();
            }
            db.Genres.Remove(genre);
            db.SaveChanges();

        }
        public void AddGenreToFilm(string film, string genre)
        {
            FilmsGenre fg = new FilmsGenre();
            fg.Genre = db.Genres.Where(p => (p.GenreName == genre)).FirstOrDefault();
            fg.Film = db.Films.Where(p => (p.FilmName == film)).FirstOrDefault(); 
            db.FilmsGenres.Add(fg);
            db.SaveChanges();
            
        }
    }
}
