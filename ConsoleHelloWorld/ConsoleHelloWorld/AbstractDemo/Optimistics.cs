using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.AbstractDemo
{
    internal class Optimistics : Personalities
    {
        public override void PrintStatus()
        {
            Console.WriteLine("I dont wont go to work...");
        }
    }
}
