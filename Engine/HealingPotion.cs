﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(Guid id, string name, string namePlural, int amountHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountHeal;
        }
    }
}
