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
        //フィールド
        protected Item item;

        //メソッド
        //コンストラクタ
        public Player(Item item)
        {
            this.item = item;
        }
        //使う
        public virtual void UseItem()
        {
            item.Use();
        }
    }

}
