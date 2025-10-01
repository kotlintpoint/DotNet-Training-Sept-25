using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.VirtualDemo
{
    internal class BadTeacher : Teacher
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("I know more than you all.");
        }
    }
}
