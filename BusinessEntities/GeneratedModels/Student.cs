using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class Student : EntityBase
    {
        public Student()
        {
            Enrollments = new ChangeTrackingCollection<Enrollment>();
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

        public DateTime EnrollmentDate
        {
            get { return _EnrollmentDate; }
            set
            {
                if (Equals(value, _EnrollmentDate)) return;
				_EnrollmentDate = value;
				NotifyPropertyChanged();
            }
        }
        private DateTime _EnrollmentDate;

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
