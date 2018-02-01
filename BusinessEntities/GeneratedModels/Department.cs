using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class Department : EntityBase
    {
        public Department()
        {
            Courses = new ChangeTrackingCollection<Course>();
        }

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

        public decimal Budget
        {
            get { return _Budget; }
            set
            {
                if (Equals(value, _Budget)) return;
				_Budget = value;
				NotifyPropertyChanged();
            }
        }
        private decimal _Budget;

        public int? InstructorId
        {
            get { return _InstructorId; }
            set
            {
                if (Equals(value, _InstructorId)) return;
				_InstructorId = value;
				NotifyPropertyChanged();
            }
        }
        private int? _InstructorId;

        public string Name
        {
            get { return _Name; }
            set
            {
                if (Equals(value, _Name)) return;
				_Name = value;
				NotifyPropertyChanged();
            }
        }
        private string _Name;

        public byte[] RowVersion
        {
            get { return _RowVersion; }
            set
            {
                if (Equals(value, _RowVersion)) return;
				_RowVersion = value;
				NotifyPropertyChanged();
            }
        }
        private byte[] _RowVersion;

        public DateTime StartDate
        {
            get { return _StartDate; }
            set
            {
                if (Equals(value, _StartDate)) return;
				_StartDate = value;
				NotifyPropertyChanged();
            }
        }
        private DateTime _StartDate;

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

        public ChangeTrackingCollection<Course> Courses
        {
            get { return _Courses; }
            set
            {
                if (Equals(value, _Courses)) return;
                _Courses = value;
                NotifyPropertyChanged();
            }
        }
        private ChangeTrackingCollection<Course> _Courses;

    }
}
