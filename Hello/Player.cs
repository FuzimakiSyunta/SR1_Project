using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Class1;

namespace Hello
{
    internal class Player
    {
        //Listコレクション items を作成する
        List<Item> items = new List<Item>();
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public virtual void UseItem()
        {
            foreach (Item item in items)
            {
                item.Use();
            }
        }
    }

}
