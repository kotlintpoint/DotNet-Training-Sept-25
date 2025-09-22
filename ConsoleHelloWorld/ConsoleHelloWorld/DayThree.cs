using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld
{
    internal class DayThree
    {
        public static void CompareStringAndStringBuilder() {

            Stopwatch sw = new Stopwatch();
            sw.Start();
            var sb = new StringBuilder();
            for (var i = 1; i <= 100000; i++) {
                sb.Append("Append String");
            }
            sw.Stop();
            var elapsed1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            var str = "";
            for (var i = 1; i <= 100000; i++)
            {
                str += "Test";
            }
            sw.Stop();
            var elapsed2 = sw.ElapsedMilliseconds;

            Console.WriteLine($"StringBuilder elapsed1 is {elapsed1} and String elapsed2 is {elapsed2}");
        }

        public static void DemoSubstring() {
            var word = "Hello World!";

            string result;
            result = word.Substring(6);
            Console.WriteLine($"word.Substring(6) = {result}");
            result = word.Substring(0, 5);
            Console.WriteLine($"word.Substring(0, 5) = {result}");
            result = word[..5];
            Console.WriteLine($"word[..5] = {result}");
            result = word[6..];
            Console.WriteLine($"word[6..] = {result}");
            result = word[..^1];    // word.Length - 1
            Console.WriteLine($"word[..^1] = {result}");
            result = word[^2..];
            Console.WriteLine($"word[^2..] = {result}");
            result = word[1..^1];
            Console.WriteLine($"word[1..^1] = {result}");

            var numbers = new int[] { 1, 2, 3 };
            var lessNumbers = numbers[..^1];
            foreach (var num in lessNumbers) {
                Console.WriteLine($"{num}");
            }

        }

        public static void CompareToDemo() {
            var a = "a";
            var b = "b";
            Console.WriteLine($"a.CompareTo(b) => {a.CompareTo(b)}");
            Console.WriteLine($"b.CompareTo(a) => {b.CompareTo(a)}");
            Console.WriteLine($"a.CompareTo(a) => {a.CompareTo(a)}");

            var cities = new string[] { "Surat", "Ahmedabad", "Baroda", "Navsari" };
            // alphabetical order sorting
            for (var i = 0; i < cities.Length; i++) {
                for (var j = i + 1; j < cities.LongLength; j++) {
                    if (cities[i].CompareTo(cities[j]) > 0) {
                        var temp = cities[i];
                        cities[i] = cities[j];
                        cities[j] = temp;
                    }
                }
            }
            foreach (var city in cities) {
                Console.WriteLine(city);
            }

            var citiesString = string.Join(".", cities);
            Console.WriteLine($"citiesString => {citiesString}");
            citiesString = citiesString.Replace(".", ", ");
            Console.WriteLine($"citiesString => {citiesString}");
            var newCities = citiesString.Split(", ");
            foreach (var city in newCities) { Console.WriteLine(city); }
        }

        public static void WriteFiles() {
            File.WriteAllText(@"F:\Documents\test.txt", "Hello World!!!!!");
            Console.WriteLine("File is Written!!!");
        }

        public static void ReadFile() {
            var data = File.ReadAllText(@"F:\Documents\test.txt");
            Console.WriteLine($"{data}");
        }

        public static void StreamReaderWriter() {
            // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            // Read and show each line from the file.
            string? line = "";
            using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
