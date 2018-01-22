

using BusinessEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessEntities.Context
{
    public class MovieContext : DbContext
    {
        //Add migration- Add-Migration NewMigration -Project "Project name"
        //Create the database and tables in it- Update-Database
        //To delete the last migration that you added -Remove-Migration
        //Reverting a migration- Update-Database LastGoodMigration

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
        //    modelBuilder.Entity<Movie>().ToTable(nameof(Movie));
        //    modelBuilder.Entity<Schedule>().ToTable(nameof(Schedule));

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
