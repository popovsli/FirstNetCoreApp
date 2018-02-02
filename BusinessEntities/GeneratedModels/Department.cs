using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Department : ITrackable, IMergeable
    {
        public Department()
        {
            Courses = new List<Course>();
        }

        public int DepartmentId { get; set; }
        public decimal Budget { get; set; }
        public int? InstructorId { get; set; }
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime StartDate { get; set; }

        public Instructor Instructor { get; set; }
        public ICollection<Course> Courses { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
