using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Person : ITrackable, IMergeable
    {
        public Person()
        {
            CourseAssignment = new List<CourseAssignment>();
            Department = new List<Department>();
            Enrollment = new List<Enrollment>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        [InverseProperty("Instructor")]
        public OfficeAssignment OfficeAssignment { get; set; }
        [InverseProperty("Instructor")]
        public ICollection<CourseAssignment> CourseAssignment { get; set; }
        [InverseProperty("Instructor")]
        public ICollection<Department> Department { get; set; }
        [InverseProperty("Student")]
        public ICollection<Enrollment> Enrollment { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
