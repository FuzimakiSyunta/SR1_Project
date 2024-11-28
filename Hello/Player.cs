using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _09_3;

namespace Hello
{
    internal class Player
    {
        private List<Item> items;

        public Player()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public void UseItems()
        {
            foreach (Item item in items)
            {
                item.Use();
            }
        }
    }

}
