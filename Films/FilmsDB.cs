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
    }
}
