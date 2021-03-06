﻿using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class CourseAssignment : ITrackable, IMergeable
    {
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Column("InstructorID")]
        public int InstructorId { get; set; }

        [ForeignKey("CourseId")]
        [InverseProperty("CourseAssignment")]
        public Course Course { get; set; }
        [ForeignKey("InstructorId")]
        [InverseProperty("CourseAssignment")]
        public Person Instructor { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
