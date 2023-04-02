using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class InventoryItem
    {
        public Item Detail { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(Item details, int quantity)
        {
            Detail = details;
            Quantity = quantity;
        }
    }
}
