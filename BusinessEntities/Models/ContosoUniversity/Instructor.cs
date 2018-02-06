﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessEntities.Models.ContosoUniversity
{
    public class Instructor : Person // Person //:BaseModel
    {
        //public int Id { get; set; }

        //[Required]
        //[Display(Name = "Last Name")]
        //[StringLength(50)]
        //public string LastName { get; set; }

        //[Required]
        //[Column("FirstName")]
        //[Display(Name = "First Name")]
        //[StringLength(50)]
        //public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        //[Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get { return LastName + ", " + FirstName; }
        //}

        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}
