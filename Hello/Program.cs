using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Class1;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Playerクラスの実体を生成する際、Itemクラスの実体を渡す
            Player player = new Player(new Item("こん棒"));

            player.UseItem();

            Console.ReadLine();
        }
    }
}
