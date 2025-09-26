using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.InheritanceDemo
{
    internal class Bird : Animal
    {

        public Bird(string name, int age, float weight) : base(name, age, weight) 
        {
            //_name = name;   // _name private so it won't work
            //setName(name);
            //setAge(age);    
            //setWeight(weight);
        }
        public void Fly() {
            if (getWeight() > 9000) {
                Console.WriteLine("Too heavy to Fly.");
                return;
            }
            Console.WriteLine("Bird Can Fly");
        }
    }
}
