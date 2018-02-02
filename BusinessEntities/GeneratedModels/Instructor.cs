using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Instructor : ITrackable, IMergeable
    {
        public Instructor()
        {
            CourseAssignments = new List<CourseAssignment>();
            Departments = new List<Department>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }
        public string LastName { get; set; }

        public OfficeAssignment OfficeAssignment { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public ICollection<Department> Departments { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
