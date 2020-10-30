using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeCheck.Models;

namespace PracticeCheck.Repository
{
    public interface IItemRepository
    {
        public IEnumerable<Item> GetItems();
        public int AddItem(Item item);
    }
}
