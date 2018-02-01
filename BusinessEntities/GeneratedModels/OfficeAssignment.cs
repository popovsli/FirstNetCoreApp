using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class OfficeAssignment : EntityBase
    {
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

        public string Location
        {
            get { return _Location; }
            set
            {
                if (Equals(value, _Location)) return;
				_Location = value;
				NotifyPropertyChanged();
            }
        }
        private string _Location;

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
