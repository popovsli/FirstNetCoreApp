using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusinessEntities.GeneratedModels
{
    public partial class GeneratedDbContext : DbContext
    {

        public GeneratedDbContext(DbContextOptions options)
                    : base(options)
        {
        }

        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseAssignment> CourseAssignment { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignment { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId);

                entity.Property(e => e.CourseId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CourseAssignment>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.InstructorId });

                entity.HasIndex(e => e.InstructorId);

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.CourseAssignment)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK_CourseAssignment_Instructor_InstructorID");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.InstructorId);

                entity.Property(e => e.RowVersion).IsRowVersion();

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK_Department_Instructor_InstructorID");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasIndex(e => e.CourseId);

                entity.HasIndex(e => e.StudentId);
            });

            modelBuilder.Entity<OfficeAssignment>(entity =>
            {
                entity.Property(e => e.InstructorId).ValueGeneratedNever();

                entity.HasOne(d => d.Instructor)
                    .WithOne(p => p.OfficeAssignment)
                    .HasForeignKey<OfficeAssignment>(d => d.InstructorId)
                    .HasConstraintName("FK_OfficeAssignment_Instructor_InstructorID");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Discriminator).HasDefaultValueSql("(N'Instructor')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
