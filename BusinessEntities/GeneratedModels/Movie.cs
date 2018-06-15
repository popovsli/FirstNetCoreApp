using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Movie : ITrackable, IMergeable
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        public decimal Price { get; set; }
        [Required]
        [StringLength(5)]
        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        [StringLength(60)]
        public string Title { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
