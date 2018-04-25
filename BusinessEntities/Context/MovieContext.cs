
using BusinessEntities.Models;
using BusinessEntities.Models.ContosoUniversity;
using BusinessEntities.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusinessEntities.Context
{
    public class MovieContext : IdentityDbContext<User, string, UserLogin, Role, UserRole, UserClaim> //IdentityDbContext
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

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Contact> Contact { get; set; }


        public virtual void Commit()
        {
            base.SaveChanges();
        }

        public virtual void Migrate()
        {
            this.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().ToTable(nameof(Movie));
            modelBuilder.Entity<Schedule>().ToTable(nameof(Schedule));

            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
            modelBuilder.Entity<CourseAssignment>().ToTable("CourseAssignment");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Contact>().ToTable("Contact");

            //modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            //modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");

            modelBuilder.Entity<CourseAssignment>()
                .HasKey(c => new { c.CourseId, c.InstructorId });

            //modelBuilder.Entity<IdentityRoleClaim<string>>()
            //  .HasKey(c => new { c.Id });

            //modelBuilder.Entity<IdentityUserToken<string>>()
            //   .HasKey(c => new { c.UserId, c.LoginProvider, c.Name });

            //base.OnModelCreating(modelBuilder);
        }
    }

    public class IdentityDbContext<TUser, TKey, TUserLogin, TRole, TUserRole, TUserClaim> : IdentityBaseDbContext<TUser, TKey, TUserLogin, TUserRole, TUserClaim>
        where TUser : IdentityUser<TKey>
        where TKey : IEquatable<TKey>
        where TUserLogin : IdentityUserLogin<TKey>
        where TRole : IdentityRole<TKey>
        where TUserRole : IdentityUserRole<TKey>
        where TUserClaim : IdentityUserClaim<TKey>
    {
        public IdentityDbContext(DbContextOptions options)
                : base(options)
        {
        }

        public DbSet<TRole> Role { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TRole>().ToTable("Role");

            modelBuilder.Entity<TRole>()
                .HasKey(c => new { c.Id });
        }
    }

    public class IdentityBaseDbContext<TUser, TKey, TUserLogin, TUserRole, TUserClaim> : DbContext
        where TKey : IEquatable<TKey>
        where TUser : IdentityUser<TKey>
        where TUserLogin : IdentityUserLogin<TKey>
        where TUserRole : IdentityUserRole<TKey>
        where TUserClaim : IdentityUserClaim<TKey>
    {
        public IdentityBaseDbContext(DbContextOptions options)
                : base(options)
        {
        }

        public DbSet<TUser> User { get; set; }
        public DbSet<TUserLogin> UserLogin { get; set; }
        public DbSet<TUserRole> UserRole { get; set; }
        public DbSet<TUserClaim> UserClaim { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TUser>().ToTable("User");
            modelBuilder.Entity<TUserLogin>().ToTable("UserLogin");
            modelBuilder.Entity<TUserRole>().ToTable("UserRole");
            modelBuilder.Entity<TUserClaim>().ToTable("UserClaim");

            modelBuilder.Entity<TUser>()
                .HasKey(c => new { c.Id });

            modelBuilder.Entity<TUserLogin>()
               .HasKey(c => new { c.LoginProvider, c.ProviderKey });

            modelBuilder.Entity<TUserRole>()
               .HasKey(c => new { c.RoleId, c.UserId });

            modelBuilder.Entity<TUserClaim>()
               .HasKey(c => new { c.Id, c.UserId });
        }
    }

}
