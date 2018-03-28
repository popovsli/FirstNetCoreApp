﻿
using BusinessEntities.Models;
using BusinessEntities.Models.ContosoUniversity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusinessEntities.Context
{
    public class MovieContext : IdentityBaseDbContext<User,string,UserLogin,Role> //IdentityDbContext
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


        public virtual void Commit()
        {
            base.SaveChanges();
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

            //modelBuilder.Entity<User>().ToTable("User");
            //modelBuilder.Entity<Role>().ToTable("Roles");

            //modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            //modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            //modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            //modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            //modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");

            modelBuilder.Entity<CourseAssignment>()
                .HasKey(c => new { c.CourseId, c.InstructorId });


            //modelBuilder.Entity<User>()
            //    .HasKey(c => new { c.Id });

            //modelBuilder.Entity<IdentityRoleClaim<string>>()
            //  .HasKey(c => new { c.Id });

            //modelBuilder.Entity<IdentityUserRole<string>>()
            //    .HasKey(c => new { c.RoleId });

            //modelBuilder.Entity<IdentityUserLogin<string>>()
            //   .HasKey(c => new { c.LoginProvider, c.ProviderKey });

            //modelBuilder.Entity<IdentityUserToken<string>>()
            //   .HasKey(c => new { c.UserId, c.LoginProvider, c.Name });

            //modelBuilder.Entity<IdentityUserClaim<string>>()
            //   .HasKey(c => new { c.Id });



            //base.OnModelCreating(modelBuilder);
        }
    }

    public class IdentityBaseDbContext<TUser, TKey, TUserLogin, TRole> : DbContext //IdentityDbContext<User, Role, string>
        where TKey : IEquatable<TKey>
        where TUser : IdentityUser<TKey>
        where TUserLogin : IdentityUserLogin<TKey>, new()
        where TRole : IdentityRole<TKey>, new()
        //where TContext : IdentityBaseDbContext<TUser, TKey, TUserLogin, TRole,TContext>
    {
        public IdentityBaseDbContext(DbContextOptions options)
                : base(options)
        {
        }

        public DbSet<TUser> User { get; set; }
        public DbSet<TRole> Role { get; set; }
        public DbSet<TUserLogin> UserLogin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TUser>().ToTable("Users");
            modelBuilder.Entity<TRole>().ToTable("Roles");
            modelBuilder.Entity<TUserLogin>().ToTable("UserLogins");

            modelBuilder.Entity<TUser>()
                .HasKey(c => new { c.Id });

            modelBuilder.Entity<TUserLogin>()
               .HasKey(c => new { c.LoginProvider, c.ProviderKey });

            modelBuilder.Entity<TRole>()
                .HasKey(c => new { c.Id });
        }
    }

}
