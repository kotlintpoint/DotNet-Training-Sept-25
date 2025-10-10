using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.DelegateDemo
{

    public delegate void HelloDelegate();
    internal class DelegateExample
    {
        public static void Hello() {
            Console.WriteLine("Hello Delegate Example.");
        }

        public static void HelloExample()
        {
            Console.WriteLine("Hello Delegate Example. Welcome, Very Good.");
        }

        // Function as Parameter
        public static void CheckDelegateAsParameter(HelloDelegate action) {
            Console.WriteLine("Before Action");
            action();
            Console.WriteLine("After Action");
        }

        public static void ToPascalCase() { 

        }
    }


    // Extension method 
    public static class StringExtension {
        public static string ToPascalCase(this string text) 
        {
            if (string.IsNullOrEmpty(text)) return text;

            return text[0].ToString().ToUpper() + text[1..];
        }
    }
}
