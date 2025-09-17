using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld
{
    internal class Student
    {
        public static void WelcomeStudent() {
            Console.WriteLine("Welcome Student");
        }

        public void HelloStudent() {
            Console.WriteLine("Hello Student");
        }

        public void Sum(int no1, int no2) {
            if (no1 < 0 || no2 < 0)
            {
                Console.WriteLine("Negative numbers Error.");
                return;
            }
            Console.WriteLine("Sum = " + (no1 + no2));
        }

        public String getName() {
            Console.Write("Enter Name : ");
            String name = Console.ReadLine()!;
            return name;
        }

        static int readNumber()
        {
            Console.Write("Enter Number : ");
            int num;
            bool isNumber = int.TryParse(Console.ReadLine()!, out num);
            if (isNumber)
            {
                return num;
            }
            Console.WriteLine("Please Enter number...");
            return 0;
        }

        public static void doMultiplication() {            
            int num1 = readNumber();
            int num2 = readNumber();
            int mul = num1 * num2;
            Console.WriteLine($"Multiplication : {mul}");
        }
    }
}
