using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Course : ITrackable, IMergeable
    {
        public Course()
        {
            CourseAssignments = new List<CourseAssignment>();
            Enrollments = new List<Enrollment>();
        }

        public int CourseId { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public string Title { get; set; }

        public Department Department { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
