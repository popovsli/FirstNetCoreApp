

using BusinessEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessEntities.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
                : base(options)
        {
            //if (!Database.EnsureCreated())
            //{
            //    Database.Migrate();
            //}
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Schedule> Schedule { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Movie>().ToTable(typeof(Movie).Name);
        //    modelBuilder.Entity<Schedule>().ToTable(typeof(Schedule).Name);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
