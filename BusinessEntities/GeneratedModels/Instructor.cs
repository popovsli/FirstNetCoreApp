using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class Instructor : EntityBase
    {
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
    }
}
