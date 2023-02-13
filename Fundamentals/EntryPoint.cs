using System;
using Basics;
using Inhertiance;
using StudentDetail;

// MethodLearning obj = new();
// obj.Display();

// MethodLearning obj1 = new();
// Console.WriteLine(obj1.SumOfSquare(12,34,12,33,4));


// obj.Display("Hello");
// obj.Display("Welcome");

// obj.Add(4.6f, 5.9f);
// obj.Add(43.6f, 75.9f);
// obj.Add(1214.6f, 55.49f);

// string s = obj.Greet();
// Console.WriteLine(s);

// string today = obj.GetDay();
// Console.WriteLine(today);

// float f = 12.3f, se = 45.5f, t = 234.4f;
// var sum = obj.Add(f, se, t);
// Console.WriteLine($"{f} + {se} + {t} = " + sum);

// var p = obj.Multiply(456.4, 23.22, 3456.45f);
// var p1 = obj.Multiply(456.4, 23.22f);
// Console.WriteLine("The use of Multiplying method." + p + "\n" + p1);

// var m2 = obj.SumOfSquare(123.32, 1243, 12.23);
// Console.WriteLine("The use of params arguments " + m2);

// //Named Arguments

// var p5 = obj.Multiply(z: 345.2, y: 234.2, x: 23.2);
// Console.WriteLine("The named arguments value: " + p5);
// var p6 = obj.Divide(23.55f, 2.1f);

// int mini = obj.CheckMinimum(12, 3, 4, 11, 1, 2, 4);
// Console.WriteLine(mini);

// (int, int) minmax = obj.CheckMinMax(12, 23, 2, 1, 56, 657, 43, 89, 2);
// Console.WriteLine("Tuple returned value " + minmax);

// Test test1 = new();

// Assignments_Methods obj = new();

// double m1 = obj.CalculateProductOfSquare(12, 12);
// Console.WriteLine("The product of square of two supplied number is " + m1);

// double m2 = obj.CalculateCubeRoot(23);
// Console.WriteLine("The cuberoot of given number is " + m2);


// string m3 = obj.CalculateBMI(62, 5.6f);
// Console.WriteLine(m3);

// Test2 obj = new();
// obj.T();

// var bcar1 = new Vehicle("Car","Nexon","Tata",4,15.5f,"BA.33 PA");
// var car1 = new OilEngineVehicle("Car","Nexon","Tata",4,15.5f,"BA.33 PA",1500f);
// car1.PrintDetails();


// var laptop1 = new Macbook("Apple","M1MacbookPro",350000,"M1");
// laptop1.PrintLaptopDetail();

// var laptop2 = new ManageLaptops("Apple","M1MacbookPro",350000,7);
// laptop2.CalculateWinBatterLife();
// laptop2.CalculateMacBatterLife();

//Phone phone1 = new("Apple","iphone 13",new DateTime(2022,9,16));
// Phone phone1 = new();
// phone1.Brand = ("A");
// phone1.Model = "iphone 14";
// phone1.ReleaseDate = new DateTime(2022,9,16);
// var f = phone1.ChipManuFacturer;
Student child = new();
child.FullName = "Happy Singh";
byte childAge = child.Standard;
var x  = child.Age = 13;

Console.WriteLine("Name of a student: "+child.FullName);
Console.WriteLine("Student studies in standard: "+child.Standard);
Console.WriteLine("Age of the student is: " + x);
Student.PrintResult("A");
