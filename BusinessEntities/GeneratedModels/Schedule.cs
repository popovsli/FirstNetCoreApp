using System;
using System.Collections.Generic;
using TrackableEntities.Common.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntities.GeneratedModels
{
    public partial class Schedule : ITrackable, IMergeable
    {
        [Column("ID")]
        public int Id { get; set; }
        public string PrivateSchedule { get; set; }
        public long PrivateScheduleSize { get; set; }
        public string PublicSchedule { get; set; }
        public long PublicScheduleSize { get; set; }
        public string Title { get; set; }
        [Column("UploadDT")]
        public DateTime UploadDt { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
