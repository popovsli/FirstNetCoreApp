using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TrackableEntities.Common.Core;

namespace BusinessEntities.Models
{
    public class BaseModel : ITrackable, IMergeable
    {
        [NotMapped]
        public Guid EntityIdentifier { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }

        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
