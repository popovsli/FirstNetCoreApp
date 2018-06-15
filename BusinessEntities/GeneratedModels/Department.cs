using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Department : ITrackable, IMergeable
    {
        public Department()
        {
            Course = new List<Course>();
        }

        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }
        [Column("InstructorID")]
        public int? InstructorId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime StartDate { get; set; }

        [ForeignKey("InstructorId")]
        [InverseProperty("Department")]
        public Person Instructor { get; set; }
        [InverseProperty("Department")]
        public ICollection<Course> Course { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
