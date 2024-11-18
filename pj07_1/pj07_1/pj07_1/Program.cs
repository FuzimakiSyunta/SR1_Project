using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pj07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(Environment.TickCount);
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++) 
            {
                int r = random.Next(-5, 5);
                numbers.Add(r);
                Console.WriteLine(r);
            }
            Console.WriteLine("---");
            //一時停止
            Console.ReadLine();
        }
    }
}
