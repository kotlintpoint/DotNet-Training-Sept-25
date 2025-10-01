using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.VirtualDemo
{
    internal class GoodTeacher: Teacher
    {
        public override void Work()
        {
            Console.WriteLine("Learning with my Students.");
        }
    }
}
