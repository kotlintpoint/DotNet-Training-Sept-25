using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.InheritanceDemo
{
    internal class Animal
    {
        private int _age;
        public void setAge(int age) { _age = age; }
        public int getAge() { return _age; }

        private string _name;
        public string getName() { return _name; }
        public void setName(string name) { _name = name; }

        private float _weight;
        public float getWeight() { return _weight; }
        public void setWeight(float weight) { _weight = weight; }

        public Animal(string name, int age, float weight)
        {
            Console.WriteLine("Animal Constructor with params");
            _name = name;
            _age = age;
            _weight = weight;
        }

        public Animal() {
            Console.WriteLine("Animal Constructor");
        }
    }
}
