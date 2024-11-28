using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Item item = new Item("つるはし");

            //item.Use();

            //Console.ReadLine();

            Player player = new Player(new Item("こん棒"));

            player.UseItem();

            Console.ReadLine();
        }
    }
}
