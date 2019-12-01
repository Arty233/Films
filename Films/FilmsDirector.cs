namespace Films
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FilmsDirector
    {
        public int ID { get; set; }

        public int FilmID { get; set; }

        public int DirectorID { get; set; }

        public virtual Director Director { get; set; }

        public virtual Film Film { get; set; }
    }
}
