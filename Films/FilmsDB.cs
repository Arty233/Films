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

        public User NewUser(string log, string pass, bool isAdmin)
        {

        }
    }
}
