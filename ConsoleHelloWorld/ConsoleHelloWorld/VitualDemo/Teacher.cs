using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.VirtualDemo
{
    internal class Teacher
    {
        public virtual void Work() {
            Console.WriteLine("Teaching");
        }
    }
}
