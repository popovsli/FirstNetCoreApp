using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class CourseAssignment : EntityBase
    {
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

        public int InstructorId
        {
            get { return _InstructorId; }
            set
            {
                if (Equals(value, _InstructorId)) return;
				_InstructorId = value;
				NotifyPropertyChanged();
            }
        }
        private int _InstructorId;

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

        public Instructor Instructor
        {
            get { return _Instructor; }
            set
            {
                if (Equals(value, _Instructor)) return;
                _Instructor = value;
                InstructorChangeTracker = _Instructor == null ? null
				: new ChangeTrackingCollection<Instructor> { _Instructor };
			    NotifyPropertyChanged();
            }
        }
        private Instructor _Instructor;
        private ChangeTrackingCollection<Instructor> InstructorChangeTracker { get; set; }

    }
}
