using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class Course : EntityBase
    {
        public Course()
        {
            CourseAssignments = new ChangeTrackingCollection<CourseAssignment>();
            Enrollments = new ChangeTrackingCollection<Enrollment>();
        }

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

        public int Credits
        {
            get { return _Credits; }
            set
            {
                if (Equals(value, _Credits)) return;
				_Credits = value;
				NotifyPropertyChanged();
            }
        }
        private int _Credits;

        public int DepartmentId
        {
            get { return _DepartmentId; }
            set
            {
                if (Equals(value, _DepartmentId)) return;
				_DepartmentId = value;
				NotifyPropertyChanged();
            }
        }
        private int _DepartmentId;

        public string Title
        {
            get { return _Title; }
            set
            {
                if (Equals(value, _Title)) return;
				_Title = value;
				NotifyPropertyChanged();
            }
        }
        private string _Title;

        public Department Department
        {
            get { return _Department; }
            set
            {
                if (Equals(value, _Department)) return;
                _Department = value;
                DepartmentChangeTracker = _Department == null ? null
				: new ChangeTrackingCollection<Department> { _Department };
			    NotifyPropertyChanged();
            }
        }
        private Department _Department;
        private ChangeTrackingCollection<Department> DepartmentChangeTracker { get; set; }

        public ChangeTrackingCollection<CourseAssignment> CourseAssignments
        {
            get { return _CourseAssignments; }
            set
            {
                if (Equals(value, _CourseAssignments)) return;
                _CourseAssignments = value;
                NotifyPropertyChanged();
            }
        }
        private ChangeTrackingCollection<CourseAssignment> _CourseAssignments;

        public ChangeTrackingCollection<Enrollment> Enrollments
        {
            get { return _Enrollments; }
            set
            {
                if (Equals(value, _Enrollments)) return;
                _Enrollments = value;
                NotifyPropertyChanged();
            }
        }
        private ChangeTrackingCollection<Enrollment> _Enrollments;

    }
}
