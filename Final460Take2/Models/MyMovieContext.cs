namespace Final460Take2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyMovieContext : DbContext
    {
        public MyMovieContext()
            : base("name=MyMovieContext")
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<AllCast> AllCasts { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .HasMany(e => e.AllCasts)
                .WithRequired(e => e.Actor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Director>()
                .HasMany(e => e.Movies)
                .WithRequired(e => e.Director)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.AllCasts)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);
        }
    }
}
