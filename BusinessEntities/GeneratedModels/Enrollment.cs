using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Enrollment : ITrackable, IMergeable
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int? Grade { get; set; }
        public int StudentId { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
