using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Course : ITrackable, IMergeable
    {
        public Course()
        {
            CourseAssignment = new List<CourseAssignment>();
            Enrollment = new List<Enrollment>();
        }

        [Column("CourseID")]
        public int CourseId { get; set; }
        public int Credits { get; set; }
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [StringLength(50)]
        public string Title { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("Course")]
        public Department Department { get; set; }
        [InverseProperty("Course")]
        public ICollection<CourseAssignment> CourseAssignment { get; set; }
        [InverseProperty("Course")]
        public ICollection<Enrollment> Enrollment { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
