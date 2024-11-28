using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _09_2;

namespace Hello
{
    internal class Player
    {
        //フィールド
        private _09_2.Item item;

        //コンストラクタ
        public Player(Item item)
        {
            this.item = item;
        }

        //使う
        public void UseItem()
        {
            item.Use();
        }
    }

}
