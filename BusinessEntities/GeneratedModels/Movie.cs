using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Movie : ITrackable, IMergeable
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
