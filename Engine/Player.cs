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

        public Player(int currentHp, int maxHp, int gold, int exp, int level) : base(currentHp, maxHp)
        {
            Gold = gold;
            ExpriencePoints = exp;
            Level = level;
        }
    }
}
