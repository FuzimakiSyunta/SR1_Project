using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("ロボット");
            Console.WriteLine("名前:{0}", robot.Getname());
            robot.Attack();

            FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボ");
            Console.WriteLine("名前:{0}", flyingRobot.Getname());
            flyingRobot.Attack();

            TankRobot tankRobot = new TankRobot("タンクロボ");
            Console.WriteLine("名前:{0}", tankRobot.Getname());
            tankRobot.Attack();

            //一時停止
            Console.ReadLine(); 
        }
    }
}
