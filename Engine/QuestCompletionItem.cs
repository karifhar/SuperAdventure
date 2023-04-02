using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class QuestCompletionItem
    {
        public Item Detail { get; set; }
        public int Quantity { get; set; }
        public QuestCompletionItem(Item detail, int quantity)
        {
            Detail = detail;
            Quantity = quantity;
        }
    }
}
