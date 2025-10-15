// See https://aka.ms/new-console-template for more information
//using ConsoleHelloWorld;
using ConsoleHelloWorld.AbstractDemo;
using ConsoleHelloWorld.DelegateDemo;
using ConsoleHelloWorld.IndexerDemo;
using ConsoleHelloWorld.InheritanceDemo;
using ConsoleHelloWorld.InOutRefDemo;
using ConsoleHelloWorld.InterfaceDemo;
using ConsoleHelloWorld.JsonDemo;
using ConsoleHelloWorld.VirtualDemo;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

/*
Console.WriteLine("Hello, World!");

String str = "Hello From Console Application!!!";

Console.WriteLine("Welcome " + str);

Student student = new Student();
student.HelloStudent();
student.Sum(-10, 20);
student.Sum(10, 20);
//String studentName = student.getName();
//Console.WriteLine($"Student: {studentName}");

Console.WriteLine($"Student: {student.getName()}");

// static members can be accessed directly without creating object
// Single memory allocation for static members 
Student.WelcomeStudent();

const int num = 100;
//num = 200;

Student.doMultiplication();

object name = "String";
string user = typeof(string).Name;
Console.WriteLine($"{name} == {user} : {name == user}");
Console.WriteLine($"{name} Equals {user} : {name.Equals(user)}");
*/

// Day Two

// Primitive Type 
//var num = 100;
//DayTwo.changeNumber(num);   // call by value
//Console.WriteLine($"num = {num}");

//// Reference type
//var arrayBool = new bool[3];
//Console.WriteLine("Before Initialization Boolean Array");
//Console.WriteLine($"{arrayBool[0]}, {arrayBool[1]}, {arrayBool[2]}");

//var array = new int[3];
//Console.WriteLine("Before Initialization");
//Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}");

//Console.WriteLine("After Initialization");
//array[0] = 1;
//array[1] = 2;
//array[2] = 3;
//Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}");
//Console.WriteLine("After Call by Reference");
//DayTwo.changeArray(array);     // call by reference 

//Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}");
//Console.WriteLine($"Length : {array.Length}");


//var students = new Student[3];
//Console.WriteLine($"{students[0]}, {students[1]}, {students[2]}");


//for (var i = 0; i < array.Length; i++)
//{
//    Console.Write("Enter number : ");
//    int.TryParse(Console.ReadLine(), out array[i]);
//}

//foreach (var number in array)
//{
//    Console.Write($"{number}, ");
//}

//var name = "tops technology";
////name[0] = 'T';
//Console.WriteLine(name[0]);
//Console.WriteLine(char.ToUpper(name[0]) + name.Substring(1));

//Console.WriteLine();
////DayTwo.printFibonacci(1);
////Console.WriteLine();
////DayTwo.printFibonacci(2);
////Console.WriteLine();
////DayTwo.printFibonacci(3);
////Console.WriteLine();
//DayTwo.printFibonacci(10);


// Day Three

//DayThree.CompareStringAndStringBuilder();
//DayThree.DemoSubstring();
//DayThree.CompareToDemo();
//DayThree.WriteFiles();
//DayThree.ReadFile();
//DayThree.StreamReaderWriter();

//try
//{
//    //((Object)null).ToString();
//    var num1 = 35;
//    var num2 = 5;
//    Console.WriteLine($"{num1 / num2}");
//    var num3 = int.Parse("100");

//    var person1 = new Person();
//    person1.Id = 10;
//    person1.Name = "Sachin";
//    Console.WriteLine($"Id : {person1.Id}");
//    Console.WriteLine($"Name : {person1.Name}");
//    Console.WriteLine($"Description : {person1.Description}");

//    var person2 = new Person(20, "Ajay", "No title", "No Description");
//    Console.WriteLine($"Id : {person2.Id}");
//    Console.WriteLine($"Name : {person2.Name}");
//    Console.WriteLine($"Description : {person2.Description}");

//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Error : {ex.ToString()}");
//}
//finally {
//    // will run exception occur or not 
//    Console.WriteLine("Main End.");
//}


//var bird1 = new Bird("Abcd", 5, 5000);
//bird1.Fly();

//Animal animal = new Animal();
//Animal animal1 = new Bird("Birdddd", 5, 5000);
//Animal animal2 = new Human("Humannnn", 5, 5000);

//Animal[] animals = { bird1, animal1, animal2 };

//foreach (var ani in animals) { 
//    Console.WriteLine($"{ani.getName()}---{ani.getWeight()}---{ani.getAge()}");
//    //animal.Fly();
//    if (ani is Bird)
//    {
//        Bird b1 = (Bird)ani;
//        b1.Fly();
//    }
//    else { 
//        Console.WriteLine("This Animal is not Bird");
//    }
//}
/*
var normalTeacher = new Teacher();
normalTeacher.Work();

var goodTeacher = new GoodTeacher();
goodTeacher.Work();

var badTeacher = new BadTeacher();
badTeacher.Work();

Teacher[] teachers = [
    normalTeacher, 
    goodTeacher, 
    badTeacher
 ];
Console.WriteLine("==================");
foreach (var teacher in teachers) { 
    teacher.Work();
}

//var personalities = new Personalities();

var optimistics = new Optimistics();
optimistics.PrintStatus();

var punch = new Punch();
Console.WriteLine($"Range ===> {punch.GetRange()}");
Console.WriteLine($"Damage ===> {punch.GetDamage()}");
*/

// List Demo
/*
var list = new List<int> { 10, 20, 30};
printList(list);

list.Add(50);
printList(list);

list.Insert(3, 40);
printList(list);

list.Remove(10);
printList(list);

list.RemoveAt(2);
printList(list);

//list.Add(-10);
var allPositive = list.All(x => x > 0);
Console.WriteLine($"All positive : {allPositive}");

list.Add(-10);
var anyPositive = list.Any(x => x > 0);
Console.WriteLine($"Any positive : {anyPositive}");

var count = list.Count(x => x > 20);
Console.WriteLine($"Count : {count}");

Console.WriteLine($"Element At 1 : {list.ElementAt(1)}");

Console.WriteLine($"Element At 10 : {list.ElementAtOrDefault(10)}");

var marks = new List<int> { 20, 15, 24, 30, 28 };
marks.Sort();
printList(marks);


void printList(List<int> list) {
    
    //foreach (var item in list)
    //{
    //    Console.Write($"{item}, ");
    //}
    //Console.WriteLine(); 

    list.ForEach(x => Console.Write($"{x}, "));

    Console.WriteLine();
}
*/

/*
// Jagged Array

var data = new int[2][];
data[0] = new int[2];
data[1] = new int[4];

Console.WriteLine($"Length : {data.Length}");
Console.WriteLine($"Length of data[0] : {data[0].Length}");
Console.WriteLine($"Length of data[1] : {data[1].Length}");

var count = 1;
for (var i = 0; i < data.Length; i++) {
    for (var j = 0; j < data[i].Length; j++)
    {
        data[i][j] = count++;
    }
}

for (var i = 0; i < data.Length; i++)
{
    for (var j = 0; j < data[i].Length; j++)
    {
        Console.Write($"{data[i][j]}   ");
    }
    Console.WriteLine();
}

var values = new int[2, 3];
Console.WriteLine($"Length : {values.Length}");
var num = 1;
for (var i = 0; i < values.GetLength(0); i++)
{
    for (var j = 0; j < values.GetLength(1); j++)
    {
        values[i, j] = num++;
    }
}

for (var i = 0; i < values.GetLength(0); i++)
{
    for (var j = 0; j < values.GetLength(1); j++)
    {
        Console.Write($"{values[i, j]}    ");
    }
    Console.WriteLine();
}
*/

/*
Dictionary<int, string> map = new Dictionary<int, string>();
map.Add(1, "Welcome");
map.Add(2, "Good Morning");
map.Add(3, "How are you?");

map.TryAdd(3, "Testtttt");

Console.WriteLine(map[1]);
Console.WriteLine(map[3]);
//Console.WriteLine(map[5]);

var isRemoved = map.Remove(1);
//Console.WriteLine(isRemoved);
if (isRemoved) {
    Console.WriteLine("1 is removed.");
}

string value;
map.TryGetValue(5,out value);
Console.WriteLine($"Value for 5 is {value}");

var element = map.ElementAt(0);
Console.WriteLine($"{element.Key} ===> {element.Value}");
Console.WriteLine("====for====");
for (int i = 0; i < map.Count; i++)
{
    element = map.ElementAt(i);
    Console.WriteLine($"{element.Key} ===> {element.Value}");
}

Console.WriteLine("===foreach=====");
foreach (var item in map)
{
    Console.WriteLine($"{item.Key} ===> {item.Value}");
}

var maxByMap = map.MaxBy(item => item.Key > 2);
Console.WriteLine($"{maxByMap.Key} ===> {maxByMap.Value}");
*/
/*
// Indexer

WeekDays week = new WeekDays();

// Set values using indexer
week[0] = Days.SUNDAY;
week[1] = Days.MONDAY;
week[2] = Days.TUESDAY;

// Get values using indexer
Console.WriteLine(week[0]); // Output: Sunday
Console.WriteLine(week[1]); // Output: Monday
Console.WriteLine(week[2]); // Output: Tuesday

*/

/*
// In, Out, Ref Keywords

var number = 5;

Console.WriteLine($"number => {number}");   // 5

InOutRef.changeVariableWithoutRef(number);
Console.WriteLine($"number => {number}");   // 5

InOutRef.changeVariableWithRef(ref number);
Console.WriteLine($"number => {number}");   // 15

InOutRef.changeVariableWithIn(in number);

InOutRef.changeVariableWithOut(in number, out var squareNumber, out var qubeNumber);
Console.WriteLine($"Square => {squareNumber}");
Console.WriteLine($"Qube => {qubeNumber}");

// Discard operator
InOutRef.changeVariableWithOut(in number, out var square, out _);
Console.WriteLine($"Square => {square}");

// Null conditional operator
InOutRef.TeacherWork(null);
InOutRef.TeacherWork(new Teacher());

int? aNumber = null;

aNumber = 3;

// Pattern Matching 
var numberString = aNumber switch
{
    0 => "Zero",
    1 => "One",
    2 => "Two",
    3 => "Three",
    _ => "?"
};
Console.WriteLine($"Number String : {numberString}");
*/

/*
HelloDelegate MyDelegate = DelegateExample.Hello;

MyDelegate();   

MyDelegate += DelegateExample.HelloExample;

MyDelegate();

DelegateExample.CheckDelegateAsParameter(() => Console.WriteLine("Anonymous Function Delegate Parameter"));


var name = "sachin";
name = name.ToPascalCase();
Console.WriteLine(name);
*/
/*
var person = new Person();
person.Id = 1;
person.Name = "Sachin";
person.Description = "Sachin is Good Boy.";
person.Title = "This is Title";

Console.WriteLine(person);
// Serizlization => object to json
var personJson = JsonConvert.SerializeObject(person, Formatting.Indented);

Console.WriteLine(personJson);

var personList = new List<Person> { 
    person
};

var personListJson = JsonConvert.SerializeObject(personList, Formatting.Indented);

Console.WriteLine(personListJson);


// Deserialization => json to object

var personObject = JsonConvert.DeserializeObject<Person>(personJson);
Console.WriteLine($"{personObject.Id}, {personObject.Name}, {personObject.Title}, {personObject.Description}");

var personListObject = JsonConvert.DeserializeObject<List<Person>>(personListJson);
personListObject.ForEach((p) => Console.WriteLine(p.Name));
*/

while (true) {
    Console.WriteLine("1. New Person");
    Console.WriteLine("2. Read all Persons");
    Console.WriteLine("3. Exit");

    Console.WriteLine("Enter Choice : ");
    int.TryParse(Console.ReadLine(), out var choice);
    switch (choice) {
        case 1:
            var persons = Person.ReadPersonsFromFile();

            Console.Write("Enter Id : ");
            int.TryParse(Console.ReadLine(), out var id);
            Console.Write("Enter Name : ");
            var name = Console.ReadLine() ?? "";
            Console.Write("Enter Title : ");
            var title = Console.ReadLine() ?? "";
            Console.Write("Enter Name : ");
            var description = Console.ReadLine() ?? "";

            var person = new Person(id, name, title, description);
            persons.Add(person);
            Person.WritePersonToFile(persons);
            break;
        case 2:
            var personList = Person.ReadPersonsFromFile();
            personList.ForEach((p) => Console.WriteLine(p.Name));
            break;
        case 3:
            Environment.Exit(0);
            break;
    }
}

//Person.WritePersonToFile(personList);