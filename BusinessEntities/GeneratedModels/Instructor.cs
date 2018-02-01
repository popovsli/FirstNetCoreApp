using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class Instructor : EntityBase
    {
        public Instructor()
        {
            CourseAssignments = new ChangeTrackingCollection<CourseAssignment>();
            Departments = new ChangeTrackingCollection<Department>();
        }

        public int Id
        {
            get { return _Id; }
            set
            {
                if (Equals(value, _Id)) return;
				_Id = value;
				NotifyPropertyChanged();
            }
        }
        private int _Id;

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (Equals(value, _FirstName)) return;
				_FirstName = value;
				NotifyPropertyChanged();
            }
        }
        private string _FirstName;

        public DateTime HireDate
        {
            get { return _HireDate; }
            set
            {
                if (Equals(value, _HireDate)) return;
				_HireDate = value;
				NotifyPropertyChanged();
            }
        }
        private DateTime _HireDate;

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (Equals(value, _LastName)) return;
				_LastName = value;
				NotifyPropertyChanged();
            }
        }
        private string _LastName;

        public OfficeAssignment OfficeAssignment
        {
            get { return _OfficeAssignment; }
            set
            {
                if (Equals(value, _OfficeAssignment)) return;
                _OfficeAssignment = value;
                OfficeAssignmentChangeTracker = _OfficeAssignment == null ? null
				: new ChangeTrackingCollection<OfficeAssignment> { _OfficeAssignment };
			    NotifyPropertyChanged();
            }
        }
        private OfficeAssignment _OfficeAssignment;
        private ChangeTrackingCollection<OfficeAssignment> OfficeAssignmentChangeTracker { get; set; }

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

        public ChangeTrackingCollection<Department> Departments
        {
            get { return _Departments; }
            set
            {
                if (Equals(value, _Departments)) return;
                _Departments = value;
                NotifyPropertyChanged();
            }
        }
        private ChangeTrackingCollection<Department> _Departments;

    }
}
