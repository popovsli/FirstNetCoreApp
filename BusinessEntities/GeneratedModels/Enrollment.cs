using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Enrollment : ITrackable, IMergeable
    {
        [Column("EnrollmentID")]
        public int EnrollmentId { get; set; }
        [Column("CourseID")]
        public int CourseId { get; set; }
        public int? Grade { get; set; }
        [Column("StudentID")]
        public int StudentId { get; set; }

        [ForeignKey("CourseId")]
        [InverseProperty("Enrollment")]
        public Course Course { get; set; }
        [ForeignKey("StudentId")]
        [InverseProperty("Enrollment")]
        public Person Student { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
