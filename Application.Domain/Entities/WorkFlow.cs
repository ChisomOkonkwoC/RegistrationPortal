using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Entities
{
    public class WorkFlow : BaseEntity
    {
        public string StageName { get; set; }
        public virtual ICollection<StageType> StageTypes { get; set; }
    }
}
