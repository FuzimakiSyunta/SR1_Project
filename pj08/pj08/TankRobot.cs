﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pj06_2
{
    internal class TankRobot : Robot
    {
        public TankRobot(string name) : base(name)
        {

        }


        //キャノン砲を撃つ
        public override void Attack()
        {
            Console.WriteLine("{0}は、キャノン砲を撃った!", name);
        }
    }
}