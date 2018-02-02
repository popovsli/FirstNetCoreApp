using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class CourseAssignment : ITrackable, IMergeable
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
