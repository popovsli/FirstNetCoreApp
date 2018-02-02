using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessEntities.Models.ContosoUniversity
{
    public class OfficeAssignment : BaseModel
    {
        [Key]
        public int InstructorId { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
