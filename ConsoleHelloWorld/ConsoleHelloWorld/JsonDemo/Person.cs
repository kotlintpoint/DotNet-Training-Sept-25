using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.JsonDemo
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public Person()
        {
        }

        public Person(int id, string name, string title, string description)
        {
            Id = id;
            Name = name;
            Title = title;
            Description = description;
        }

        public static void WritePersonToFile(List<Person> persons) {
            var personsJson = JsonConvert.SerializeObject(persons, Formatting.Indented);
            File.WriteAllText(@"F:\Documents\test.txt", personsJson);
            Console.WriteLine("File is Written!!!");
        }

        public static List<Person> ReadPersonsFromFile()
        {
            try
            {
                var data = File.ReadAllText(@"F:\Documents\test.txt");
                var persons = JsonConvert.DeserializeObject<List<Person>>(data);
                return persons;
            }
            catch (Exception ex)
            {
                return [];
            }
            
        }

    }


}
