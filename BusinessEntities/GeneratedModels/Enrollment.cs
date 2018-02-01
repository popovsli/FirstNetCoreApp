using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class Enrollment : EntityBase
    {
        public int EnrollmentId
        {
            get { return _EnrollmentId; }
            set
            {
                if (Equals(value, _EnrollmentId)) return;
				_EnrollmentId = value;
				NotifyPropertyChanged();
            }
        }
        private int _EnrollmentId;

        public int CourseId
        {
            get { return _CourseId; }
            set
            {
                if (Equals(value, _CourseId)) return;
				_CourseId = value;
				NotifyPropertyChanged();
            }
        }
        private int _CourseId;

        public int? Grade
        {
            get { return _Grade; }
            set
            {
                if (Equals(value, _Grade)) return;
				_Grade = value;
				NotifyPropertyChanged();
            }
        }
        private int? _Grade;

        public int StudentId
        {
            get { return _StudentId; }
            set
            {
                if (Equals(value, _StudentId)) return;
				_StudentId = value;
				NotifyPropertyChanged();
            }
        }
        private int _StudentId;

        public Course Course
        {
            get { return _Course; }
            set
            {
                if (Equals(value, _Course)) return;
                _Course = value;
                CourseChangeTracker = _Course == null ? null
				: new ChangeTrackingCollection<Course> { _Course };
			    NotifyPropertyChanged();
            }
        }
        private Course _Course;
        private ChangeTrackingCollection<Course> CourseChangeTracker { get; set; }

        public Student Student
        {
            get { return _Student; }
            set
            {
                if (Equals(value, _Student)) return;
                _Student = value;
                StudentChangeTracker = _Student == null ? null
				: new ChangeTrackingCollection<Student> { _Student };
			    NotifyPropertyChanged();
            }
        }
        private Student _Student;
        private ChangeTrackingCollection<Student> StudentChangeTracker { get; set; }

    }
}
