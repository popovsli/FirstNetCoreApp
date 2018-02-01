using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class Schedule : EntityBase
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

        public string PrivateSchedule
        {
            get { return _PrivateSchedule; }
            set
            {
                if (Equals(value, _PrivateSchedule)) return;
				_PrivateSchedule = value;
				NotifyPropertyChanged();
            }
        }
        private string _PrivateSchedule;

        public long PrivateScheduleSize
        {
            get { return _PrivateScheduleSize; }
            set
            {
                if (Equals(value, _PrivateScheduleSize)) return;
				_PrivateScheduleSize = value;
				NotifyPropertyChanged();
            }
        }
        private long _PrivateScheduleSize;

        public string PublicSchedule
        {
            get { return _PublicSchedule; }
            set
            {
                if (Equals(value, _PublicSchedule)) return;
				_PublicSchedule = value;
				NotifyPropertyChanged();
            }
        }
        private string _PublicSchedule;

        public long PublicScheduleSize
        {
            get { return _PublicScheduleSize; }
            set
            {
                if (Equals(value, _PublicScheduleSize)) return;
				_PublicScheduleSize = value;
				NotifyPropertyChanged();
            }
        }
        private long _PublicScheduleSize;

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

        public DateTime UploadDt
        {
            get { return _UploadDt; }
            set
            {
                if (Equals(value, _UploadDt)) return;
				_UploadDt = value;
				NotifyPropertyChanged();
            }
        }
        private DateTime _UploadDt;

    }
}
