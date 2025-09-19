using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld
{
    internal class DayTwo
    {
        public static void changeNumber(int num) {
            num = 0;
        }

        public static void changeArray(int[] array)
        {
            array[0] = 0;
            array[1] = 0;
            array[2] = 0;
        }

        public static void printFibonacci(int range) {
            int num1 = 0, num2 = 1;
            if (range == 1) {
                Console.Write($"{num1}  ");
                return;
            }
            Console.Write($"{num1}  {num2}  ");
            if (range > 2) {
                int sum = num1 + num2;
                Console.Write($"{sum}  ");
                for (int i = 4; i <= range; i++) {
                    num1 = num2;
                    num2 = sum;
                    sum = num1 + num2;
                    Console.Write($"{sum}  ");
                }
            }            
        }
    }
}
