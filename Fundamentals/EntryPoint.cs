using System;


MethodLearning obj = new();
obj.Display();

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

(int, int) minmax = obj.CheckMinMax(12, 23, 2, 1, 56, 657, 43, 89, 2);
Console.WriteLine("Tuple returned value " + minmax);

// Test test1 = new();