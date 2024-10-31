using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Dog
    {
        //状態や属性
        private bool hungryState;

        public Dog() {
            hungryState = true;
        }

        public void Eat()
        {
            Console.WriteLine("ぱくぱく");
            hungryState = false;
        }

        public void Run()
        {
            Console.WriteLine("わんわんわん");
            hungryState = true;//おなかすいた
        }

        public bool IsHungry()
        {
            return hungryState;
        }
    }
}
