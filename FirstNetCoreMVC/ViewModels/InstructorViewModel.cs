using BusinessEntities.Models.ContosoUniversity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstNetCoreMVC.ViewModels
{
    public class InstructorViewModel
    {
        public List<Instructor> Instructors { get; set; }
        public List<Course> Courses { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
