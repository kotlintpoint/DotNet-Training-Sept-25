// See https://aka.ms/new-console-template for more information
using ConsoleHelloWorld;
using ConsoleHelloWorld.InheritanceDemo;

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


var bird1 = new Bird("Abcd", 5, 5000);
bird1.Fly();

Animal animal = new Animal();
Animal animal1 = new Bird("Birdddd", 5, 5000);
Animal animal2 = new Human("Humannnn", 5, 5000);

Animal[] animals = { bird1, animal1, animal2 };

foreach (var ani in animals) { 
    Console.WriteLine($"{ani.getName()}---{ani.getWeight()}---{ani.getAge()}");
    //animal.Fly();
    if (ani is Bird)
    {
        Bird b1 = (Bird)ani;
        b1.Fly();
    }
    else { 
        Console.WriteLine("This Animal is not Bird");
    }
}







