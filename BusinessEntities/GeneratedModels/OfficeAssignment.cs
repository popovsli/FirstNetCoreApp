using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class OfficeAssignment : ITrackable, IMergeable
    {
        [Key]
        [Column("InstructorID")]
        public int InstructorId { get; set; }
        [StringLength(50)]
        public string Location { get; set; }

        [ForeignKey("InstructorId")]
        [InverseProperty("OfficeAssignment")]
        public Person Instructor { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
