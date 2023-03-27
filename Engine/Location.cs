﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEntern { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }


        public Location(Guid id, string name, string description, 
            Item item = null, Quest quest = null, Monster monster = null, 
            Location north = null, Location east = null, 
            Location south = null, Location west = null)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
