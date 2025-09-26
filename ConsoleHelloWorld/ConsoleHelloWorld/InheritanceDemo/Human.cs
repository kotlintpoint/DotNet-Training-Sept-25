using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.InheritanceDemo
{
    internal class Human: Animal
    {
        public Human(string name, int age, float weight) : base(name, age, weight) { }
    }
}
