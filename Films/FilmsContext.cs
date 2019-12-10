namespace Films
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FilmsContext : DbContext
    {
        public FilmsContext()
            : base("name=FilmsContext")
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmsActor> FilmsActors { get; set; }
        public virtual DbSet<FilmsDirector> FilmsDirectors { get; set; }
        public virtual DbSet<FilmsGenre> FilmsGenres { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .Property(e => e.ActorBio)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.FilmsActors)
                .WithRequired(e => e.Actor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Director>()
                .Property(e => e.DirectorBio)
                .IsUnicode(false);

            modelBuilder.Entity<Director>()
                .HasMany(e => e.FilmsDirectors)
                .WithRequired(e => e.Director)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.FilmDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.FilmsActors)
                .WithRequired(e => e.Film)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.FilmsDirectors)
                .WithRequired(e => e.Film)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.FilmsGenres)
                .WithRequired(e => e.Film)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.FilmsGenres)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.IsAdmin);
                
        }
    }
}
