﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessEntities.Models.ContosoUniversity
{
    public class Student : Person //Person //:BaseModel
    {
        //public int Id { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Display(Name = "Last Name")]
        //public string LastName { get; set; }
        //[Required]
        //[StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        //[Column("FirstName")]
        //[Display(Name = "First Name")]
        //public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        //[Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get
        //    {
        //        return LastName + ", " + FirstName;
        //    }
        //}

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
