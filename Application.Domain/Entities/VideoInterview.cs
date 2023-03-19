using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Entities
{
    public class VideoInterview : BaseEntity
    {
        public Guid StageTypeId { get; set; }
        public string VideoQuestion { get; set; }
        public string AdditionalInfo { get; set; }
        public string MaxVideoDuration { get; set; }
        public string DurationMinAndSec { get; set; }
        public int SubmissionDeadline { get; set; } 
        public virtual StageType StageTypes { get; set; }
    }
}
