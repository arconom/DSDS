﻿using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class GroupDecision
    {
        public Group Group { get; set; }
        public long GroupId { get; set; }

        public Decision Decision { get; set; }
        public long DecisionId { get; set; }

        public GroupDecision()
        {

        }
    }
}
