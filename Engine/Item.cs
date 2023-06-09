﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public Item(Guid id, string name, string namePlural)
        {
            Id = id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}
