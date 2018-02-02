using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Student : ITrackable, IMergeable
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
