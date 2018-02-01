using System;
using System.Collections.Generic;
using TrackableEntities.Client;

namespace BusinessEntities.GeneratedModels
{
    public partial class Movie : EntityBase
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

        public string Genre
        {
            get { return _Genre; }
            set
            {
                if (Equals(value, _Genre)) return;
				_Genre = value;
				NotifyPropertyChanged();
            }
        }
        private string _Genre;

        public decimal Price
        {
            get { return _Price; }
            set
            {
                if (Equals(value, _Price)) return;
				_Price = value;
				NotifyPropertyChanged();
            }
        }
        private decimal _Price;

        public string Rating
        {
            get { return _Rating; }
            set
            {
                if (Equals(value, _Rating)) return;
				_Rating = value;
				NotifyPropertyChanged();
            }
        }
        private string _Rating;

        public DateTime ReleaseDate
        {
            get { return _ReleaseDate; }
            set
            {
                if (Equals(value, _ReleaseDate)) return;
				_ReleaseDate = value;
				NotifyPropertyChanged();
            }
        }
        private DateTime _ReleaseDate;

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

    }
}
