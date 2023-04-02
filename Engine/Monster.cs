using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; } = new List<LootItem>();

        public Monster(Guid id, string name, int rewardExperiencePoints, int rewardGold, int maximumDamage, int currentHp, int maxHp) : base(currentHp, maxHp)
        {
            Id = id;
            Name = name;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            MaximumDamage = maximumDamage;
        }
    }
}
