using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExpriencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; } = new List<InventoryItem>();
        public List<PlayerQuest> Quests { get; set; } = new List<PlayerQuest>();

        public Player(int currentHp, int maxHp, int gold, int exp, int level) : base(currentHp, maxHp)
        {
            Gold = gold;
            ExpriencePoints = exp;
            Level = level;
        }
    }
}
