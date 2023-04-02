using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locatios = new List<Location>();

        public const string ITEM_ID_RUSTY_SWORD = "a8df6982-a6ce-4c12-a2c8-9d996d060773";
        public const string ITEM_ID_RAT_TAIL = "ca531a22-5c6d-435a-8986-9f7c07d7206d";
        public const string ITEM_ID_PIECE_OF_FUR = "300ed72e-9451-484a-b676-552a5c0bc96f";
        public const string ITEM_ID_SNAKE_FANG = "faa72f5f-23f2-4471-a9d1-1085301ad2ec";
        public const string ITEM_ID_SNAKESKIN = "82b8af0d-9083-4a2b-a2fd-20bda13c6fe9";
        public const string ITEM_ID_CLUB = "68d64a84-50a9-4319-9197-cfcf5d3ad01c";
        public const string ITEM_ID_HEALING_POTION = "86b5a2a7-4d68-4437-a266-23ea3dbdef06";
        public const string ITEM_ID_SPIDER_FANG = "6c669cf3-50ac-4d2b-a3cf-59d1587c53a5";
        public const string ITEM_ID_SPIDER_SILK = "f11ca1de-e2c7-4ac5-bc5b-e3e538bce94a";
        public const string ITEM_ID_ADVENTURER_PASS = "a42f17fb-8685-4c68-b01f-cdae0274629c";

        public const string MONSTER_ID_RAT = "3a956767-d6b7-41ff-8122-28da1ca5400b";
        public const string MONSTER_ID_SNAKE = "38cb0322-1627-498a-8f2e-49d134b811c3";
        public const string MONSTER_ID_GIANT_SPIDER = "513e7918-0ffc-43ea-ad0b-707b6acc4602";

        public const string QUEST_ID_CLEAR_ALCHEMIST_GARDEN = "43aaf4d6-83fd-4dfe-8954-b9b2056b3714";
        public const string QUEST_ID_CLEAR_FARMERs_FIELD = "854cbc39-46ef-4491-9ebd-6e8e2f5c6873";

        public const string LOCATION_ID_HOME = "33c83227-341e-4f70-a095-447c0ee6a013";
        public const string LOCATION_ID_TOME_SQUARE = "48e30845-ff09-46e6-a09c-9845ca876314";
        public const string LOCATION_ID_GUARD_POST = "58f702b4-df65-49bb-8013-452db15122bc";
        public const string LOCATION_ID_ALCHEMIST_HUT = "c5b46e0a-5cac-4136-acbf-c0630e9d7a6c";
        public const string LOCATION_ID_ALCHEMIST_GARDEN = "c2ee03c5-5336-4a25-922f-b4cc371ae36e";
        public const string LOCATION_ID_FARMHOUSE = "1d8cbfce-0013-4c1e-8806-9fc92869a84a";
        public const string LOCATION_ID_FARM_FIELD = "159b03a6-5739-487c-815b-3b92944bddc4";
        public const string LOCATION_ID_BRIDGE = "ff6fe6c4-c5cd-480b-bec0-6373a197ef7a";
        public const string LOCATION_SPIDER_FIELD = "beaea3dc-e7a6-4d2e-afbf-9e79663c0760";

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateLocations()
        {
            throw new NotImplementedException();
        }

        private static void PopulateQuests()
        {
            throw new NotImplementedException();
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(new Guid(MONSTER_ID_RAT), "Rat", 5, 5, 5, 10, 10);
            rat.LootTable.Add(new LootItem(ItemById(new Guid(ITEM_ID_RAT_TAIL)), 75, false));
            rat.LootTable.Add(new LootItem(ItemById(new Guid(ITEM_ID_PIECE_OF_FUR)), 75, true));

            Monster snake = new Monster(new Guid(MONSTER_ID_SNAKE), "Snake", 7, 7, 7, 15, 14);
            snake.LootTable.Add(new LootItem(ItemById(new Guid(ITEM_ID_SNAKE_FANG)), 75, false));
            snake.LootTable.Add(new LootItem(ItemById(new Guid(ITEM_ID_SNAKESKIN)), 75, true));

            Monster giantSpider = new Monster(new Guid(MONSTER_ID_GIANT_SPIDER), "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemById(new Guid(ITEM_ID_SPIDER_FANG)), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemById(new Guid(ITEM_ID_SPIDER_SILK)), 25, false));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(new Guid(ITEM_ID_RUSTY_SWORD), "Rusty Sword", "Rusty Swords", 1, 5));
            Items.Add(new Item(new Guid(ITEM_ID_RAT_TAIL), "Rat tail", "Rat tails"));
            Items.Add(new Item(new Guid(ITEM_ID_PIECE_OF_FUR), "Piece of fur", "Pieces of fur"));
            Items.Add(new Item(new Guid(ITEM_ID_SNAKE_FANG), "Snake fang", "Snake fangs"));
            Items.Add(new Item(new Guid(ITEM_ID_SNAKESKIN), "Snakeskin", "Snakeskins"));
            Items.Add(new Weapon(new Guid(ITEM_ID_CLUB), "Club", "Clubs", 3, 10));
            Items.Add(new HealingPotion(new Guid(ITEM_ID_HEALING_POTION), "Healing potion", "Healing potions", 15));
            Items.Add(new Item(new Guid(ITEM_ID_SPIDER_FANG), "Spider fang", "Spider fangs"));
            Items.Add(new Item(new Guid(ITEM_ID_SPIDER_SILK), "Spider silk", "Spider silks"));
            Items.Add(new Item(new Guid(ITEM_ID_ADVENTURER_PASS), "Adventurer pass", "Adventurer passes"));
        }


        public static Item ItemById(Guid id)
        {
            foreach (Item item in Items)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

    }
}
