﻿using BusinessEntities.Context;
using BusinessEntities.Models;
using BusinessEntities.Models.ContosoUniversity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities.DBInitializer
{
    public static class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (!context.Movie.Any())
            {
                var movies = new Movie[]
                        {
                             new Movie{ Title = "GTA 4" , ReleaseDate = new DateTime(2010,08,22),Genre = "Shooter" ,Price = 60,Rating = "AAA"},
                             new Movie{ Title = "GTA 5" , ReleaseDate = new DateTime(2016,08,22),Genre = "Shooter" ,Price = 50,Rating = "AAAA"},
                             new Movie{ Title = "Dungeon Hunter" , ReleaseDate = new DateTime(2010,08,22),Genre = "RPG" ,Price = 5,Rating = "AAA"},
                             new Movie{ Title = "Dungeon Hunter 2" , ReleaseDate = new DateTime(2011,08,22),Genre = "RPG" ,Price = 10,Rating = "AAA"},
                             new Movie{ Title = "Dungeon Hunter 3" , ReleaseDate = new DateTime(2012,08,22),Genre = "RPG" ,Price = 15,Rating = "AAA"}
                        };
                context.Movie.AddRange(movies);
                context.SaveChanges();
            }

            // Look for any students.
            if (!context.Students.Any())
            {
                var students = new Student[]
{
                new Student { FirstName = "Carson",   LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2010-09-01") },
                new Student { FirstName = "Meredith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstName = "Arturo",   LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstName = "Gytis",    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstName = "Yan",      LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstName = "Peggy",    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2011-09-01") },
                new Student { FirstName = "Laura",    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstName = "Nino",     LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") }
};

                foreach (Student s in students)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();

                var instructors = new Instructor[]
                {
                new Instructor { FirstName = "Kim",     LastName = "Abercrombie",
                    HireDate = DateTime.Parse("1995-03-11") },
                new Instructor { FirstName = "Fadi",    LastName = "Fakhouri",
                    HireDate = DateTime.Parse("2002-07-06") },
                new Instructor { FirstName = "Roger",   LastName = "Harui",
                    HireDate = DateTime.Parse("1998-07-01") },
                new Instructor { FirstName = "Candace", LastName = "Kapoor",
                    HireDate = DateTime.Parse("2001-01-15") },
                new Instructor { FirstName = "Roger",   LastName = "Zheng",
                    HireDate = DateTime.Parse("2004-02-12") }
                };

                foreach (Instructor i in instructors)
                {
                    context.Instructors.Add(i);
                }
                context.SaveChanges();

                var departments = new Department[]
                {
                new Department { Name = "English",     Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorId  = instructors.Single( i => i.LastName == "Abercrombie").Id },
                new Department { Name = "Mathematics", Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorId  = instructors.Single( i => i.LastName == "Fakhouri").Id },
                new Department { Name = "Engineering", Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorId  = instructors.Single( i => i.LastName == "Harui").Id },
                new Department { Name = "Economics",   Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorId  = instructors.Single( i => i.LastName == "Kapoor").Id }
                };

                foreach (Department d in departments)
                {
                    context.Departments.Add(d);
                }
                context.SaveChanges();

                var courses = new Course[]
                {
                new Course {CourseId = 1050, Title = "Chemistry",      Credits = 3,
                    DepartmentId = departments.Single( s => s.Name == "Engineering").DepartmentId
                },
                new Course {CourseId = 4022, Title = "Microeconomics", Credits = 3,
                    DepartmentId = departments.Single( s => s.Name == "Economics").DepartmentId
                },
                new Course {CourseId = 4041, Title = "Macroeconomics", Credits = 3,
                    DepartmentId = departments.Single( s => s.Name == "Economics").DepartmentId
                },
                new Course {CourseId = 1045, Title = "Calculus",       Credits = 4,
                    DepartmentId = departments.Single( s => s.Name == "Mathematics").DepartmentId
                },
                new Course {CourseId = 3141, Title = "Trigonometry",   Credits = 4,
                    DepartmentId = departments.Single( s => s.Name == "Mathematics").DepartmentId
                },
                new Course {CourseId = 2021, Title = "Composition",    Credits = 3,
                    DepartmentId = departments.Single( s => s.Name == "English").DepartmentId
                },
                new Course {CourseId = 2042, Title = "Literature",     Credits = 4,
                    DepartmentId = departments.Single( s => s.Name == "English").DepartmentId
                },
                };

                foreach (Course c in courses)
                {
                    context.Courses.Add(c);
                }
                context.SaveChanges();

                var officeAssignments = new OfficeAssignment[]
                {
                new OfficeAssignment {
                    InstructorId = instructors.Single( i => i.LastName == "Fakhouri").Id,
                    Location = "Smith 17" },
                new OfficeAssignment {
                    InstructorId = instructors.Single( i => i.LastName == "Harui").Id,
                    Location = "Gowan 27" },
                new OfficeAssignment {
                    InstructorId = instructors.Single( i => i.LastName == "Kapoor").Id,
                    Location = "Thompson 304" },
                };

                foreach (OfficeAssignment o in officeAssignments)
                {
                    context.OfficeAssignments.Add(o);
                }
                context.SaveChanges();

                var courseInstructors = new CourseAssignment[]
                {
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Chemistry" ).CourseId,
                    InstructorId = instructors.Single(i => i.LastName == "Kapoor").Id
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Chemistry" ).CourseId,
                    InstructorId = instructors.Single(i => i.LastName == "Harui").Id
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Microeconomics" ).CourseId,
                    InstructorId = instructors.Single(i => i.LastName == "Zheng").Id
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Macroeconomics" ).CourseId,
                    InstructorId = instructors.Single(i => i.LastName == "Zheng").Id
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Calculus" ).CourseId,
                    InstructorId = instructors.Single(i => i.LastName == "Fakhouri").Id
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Trigonometry" ).CourseId,
                    InstructorId = instructors.Single(i => i.LastName == "Harui").Id
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Composition" ).CourseId,
                    InstructorId = instructors.Single(i => i.LastName == "Abercrombie").Id
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Literature" ).CourseId,
                    InstructorId = instructors.Single(i => i.LastName == "Abercrombie").Id
                    },
                };

                foreach (CourseAssignment ci in courseInstructors)
                {
                    context.CourseAssignments.Add(ci);
                }
                context.SaveChanges();

                var enrollments = new Enrollment[]
                {
                new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Alexander").Id,
                    CourseId = courses.Single(c => c.Title == "Chemistry" ).CourseId,
                    Grade = Grade.A
                },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Alexander").Id,
                    CourseId = courses.Single(c => c.Title == "Microeconomics" ).CourseId,
                    Grade = Grade.C
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Alexander").Id,
                    CourseId = courses.Single(c => c.Title == "Macroeconomics" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                        StudentId = students.Single(s => s.LastName == "Alonso").Id,
                    CourseId = courses.Single(c => c.Title == "Calculus" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                        StudentId = students.Single(s => s.LastName == "Alonso").Id,
                    CourseId = courses.Single(c => c.Title == "Trigonometry" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Alonso").Id,
                    CourseId = courses.Single(c => c.Title == "Composition" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Anand").Id,
                    CourseId = courses.Single(c => c.Title == "Chemistry" ).CourseId
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Anand").Id,
                    CourseId = courses.Single(c => c.Title == "Microeconomics").CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Barzdukas").Id,
                    CourseId = courses.Single(c => c.Title == "Chemistry").CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Li").Id,
                    CourseId = courses.Single(c => c.Title == "Composition").CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Justice").Id,
                    CourseId = courses.Single(c => c.Title == "Literature").CourseId,
                    Grade = Grade.B
                    }
                };

                foreach (Enrollment e in enrollments)
                {
                    var enrollmentInDataBase = context.Enrollments.Where(
                        s =>
                                s.Student.Id == e.StudentId &&
                                s.Course.CourseId == e.CourseId).SingleOrDefault();
                    if (enrollmentInDataBase == null)
                    {
                        context.Enrollments.Add(e);
                    }
                }
                context.SaveChanges();
            }

            if (!context.Contact.Any())
            {
                context.Contact.AddRange(new Contact
                {
                    Name = "Debra Garcia",
                    Address = "1234 Main St",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10999",
                    Email = "debra@example.com"
                },
                new Contact { Name = "Thorsten Weinrich", Address = "5678 1st Ave W", City = "Redmond", State = "WA", Zip = "10999", Email = "thorsten@example.com" },
                new Contact { Name = "Yuhong Li", Address = "9012 State st", City = "Redmond", State = "WA", Zip = "10999", Email = "yuhong@example.com" },
                new Contact { Name = "Jon Orton", Address = "3456 Maple St", City = "Redmond", State = "WA", Zip = "10999", Email = "jon@example.com" },
                new Contact { Name = "Diliana Alexieva-Bosseva", Address = "7890 2nd Ave E", City = "Redmond", State = "WA", Zip = "10999", Email = "diliana@example.com" });
                context.SaveChanges();
            }
        }
    }
}

