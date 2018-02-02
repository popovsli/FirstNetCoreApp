using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models.ContosoUniversity
{
    public class CourseAssignment : BaseModel
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
