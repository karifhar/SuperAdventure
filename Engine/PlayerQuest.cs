﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        public Quest Detail { get; set; }
        public bool IsComplete { get; set; }
        public PlayerQuest(Quest detail)
        {
            Detail = detail;
            IsComplete = false;
        }
    }
}
