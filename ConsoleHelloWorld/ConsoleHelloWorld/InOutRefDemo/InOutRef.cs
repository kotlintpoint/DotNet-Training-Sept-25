using ConsoleHelloWorld.VirtualDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.InOutRefDemo
{
    internal class InOutRef
    {
        public static void changeVariableWithoutRef(int number)
        {
            number += 10;
        }
        public static void changeVariableWithRef(ref int number) {
            number += 10;
        }

        public static void changeVariableWithIn(in int number)
        {
            //number += 10;
            Console.WriteLine("Can't change in parameter");
        }

        public static void changeVariableWithOut(in int number, out int twiceNumber, out int thriceNumber)
        {
            twiceNumber = number * number;
            thriceNumber = number * number * number;
        }

        public static void TeacherWork(Teacher teacher) { 
            Console.WriteLine("Null conditional operator");
            //if (teacher != null) {
            //    teacher.Work();
            //}
            
            teacher?.Work();
        }

        // Generic Method
        public static void YouValur<T1, T2>(T1 value, T2 value2) {
            if (value is int) {
                int result = Convert.ToInt32(value) + 10;
            }            
            Console.WriteLine($"your value is {value}");
        }
    }
}
