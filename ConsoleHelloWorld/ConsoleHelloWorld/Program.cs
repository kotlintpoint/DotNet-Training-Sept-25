// See https://aka.ms/new-console-template for more information
using ConsoleHelloWorld;

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


