using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeCheck.Models;
using PracticeCheck.Repository;

namespace PracticeCheck.Repository
{
    public class ItemRepository:IItemRepository
    {
        private static List<Item> lst = new List<Item>() { new Item { ItemId = 1, ItemName = "Chole Bhature", Price = 60 } };
        public int AddItem(Item item)
        {
            if (item != null)
            {
                lst.Add(item);
                return 1;
            }
            return 0;
        }

        public IEnumerable<Item> GetItems()
        {
            return lst;
        }
    }
}
