﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Entities
{
    public class Preview : BaseEntity
    {
        public virtual ProgramDetail ProgramDetails { get; set; }
    }
}
