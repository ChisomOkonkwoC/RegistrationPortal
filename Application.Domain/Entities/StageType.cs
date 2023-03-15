using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Entities
{
    public class StageType : BaseEntity
    {
        public Guid WorkFlowId { get; set; }
        public string Placement { get; set; }
        public string ShortList { get; set; }
        public string Applied { get; set; }
        public string Offered { get; set; }
        public virtual WorkFlow WorkFlows { get; set; }
        public virtual ICollection<VideoInterview> VideoInterviews { get; set; }

    }
}
