using pj06_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(Environment.TickCount);
            List<Robot> robots = new List<Robot>();


            for (int i = 0; i < 15; i++)
            {
                int r = random.Next(1, 2+1);
                if (r == 1)
                {
                    robots.Add(new TankRobot("タンクロボ"));
                }else
                {
                    robots.Add(new TankRobot("空中ロボ"));
                }
            }

            foreach (Robot robot in robots)
            {
                robot.Attack();
            }

            //一時停止
            Console.ReadLine();
        }
    }
}
