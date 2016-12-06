namespace _460HW8.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyPiratesContext : DbContext
    {
        public MyPiratesContext()
            : base("name=MyPiratesContext")
        {
        }

        public virtual DbSet<Crew> Crews { get; set; }
        public virtual DbSet<Pirate> Pirates { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pirate>()
                .HasMany(e => e.Crews)
                .WithRequired(e => e.Pirate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ship>()
                .HasMany(e => e.Crews)
                .WithRequired(e => e.Ship)
                .WillCascadeOnDelete(false);
        }
    }
}
