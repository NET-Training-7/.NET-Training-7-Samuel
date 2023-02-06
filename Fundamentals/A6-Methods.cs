using System;
class MethodLearning
{
    // returns nothing, takes no argument
    public void Display()
    {
        Console.WriteLine("I am the simplest method possible.");
    }

    // returns nothing, takes argument 
    // Method Overloading (part of Polymorphism -OOP)
    public void Display(string greeting)
    {
        Console.WriteLine(greeting + " guys, I am learning Methods in C#");
    }

    // returns nothing takes argument
    public void Add(float first, float second)
    {
        float sum = first + second;
        string dText = $"{first} + {second} = {sum}"; // string interpolation
        Console.WriteLine(dText); // 3 + 7 = 10
    }

    // Returns something takes no arguments
    public string Greet()
    {
        var text = "Hi guys, I am simplest possible method in C#.";
        return text;
    }

    public string GetDay()
    {
        var day = DateTime.Today.DayOfWeek.ToString();
        return day;
    }

    // Returns something, takes somet arguments
    public float Add(float first, float second, float third)
    {
        float sum = first + second + third;
        return sum;

    }

    // Returns something, takes some Optional parameters of arguments

    public double Multiply(double x, double y, double z = 1)
    {
        var product = x * y * z;
        return product;
    }
    public double SumOfSquare(params double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num * num;
        }
        return sum;
    }


    // Expression bodied members:
    public float Divide(float first, float second) => first / second;


    // Write a method to calculate minumum among supplied numbers
    public int CheckMinimum(params int[] numbers)
    {
        int minimum = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }
        return minimum;
    }

    // Returning multiple values
public (int,int) CheckMinMax(params int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if(numbers[i]>max)
            {
                max = numbers[i];
            }
        }
        return (min,max);  // Tuple
    }
}
//using System;

// class MethodLearner
// {
//     // Method that returns nothing, takes no arguments
//     public void Display()
//     {
//         Console.WriteLine("Hello guys, I am simplest possible method in C#.");       
//     }

//     // Returns nothing, takes some arguments
//     // Method overloading (Polymorphism - OOP)
//     public void Display(string greeting)
//     {
//         Console.WriteLine($"{greeting} guys, I am simplest possible method in C#.");       
//     }

//     public void Add(float first, float second)
//     {
//         float sum = first + second; // Augend + Addend
//         string dText = $"{first} plus {second} equals {sum}";     // String interpolation

//         Console.WriteLine(dText);  //3 + 7 = 10
//     }

//     // Returns something, takes no arguments
//     public string Greet()
//     {
//         string text = "Hi guys, I am simplest possible method in C#.";
//         return text;       
//     }

//     public string GetDay()
//     {
//         var d = DateTime.Today.DayOfWeek.ToString();
//         string today = $"It's {d}";
//         return today;  
//     }

//     // Returns something, takes some arguements
//     public float Add(float first, float second, float third)
//     {
//         float sum = first + second + third;
//         return sum;
//     }

//     // Optional parameters, variable number of arguments (params)
//     public double Multiply(double x, double y, double z = 1)
//     {
//         var product = x * y * z;    // Multiplicand * Multiplier
//         return product;
//     }

//     public double SumOfSquares(params double[] numbers)
//     {
//         double sum = 0;
//         foreach(double num in numbers)
//         {
//             sum = sum + num * num;
//         }

//         return sum;
//     }

//     // Expression bodied memmbers
//     public float Divide(float first, float second) => first / second;

//     // Write a method to calulate minimum among supplied numbers.
//     public int CalculateMin(params int[] numbers)   // 4,6,1,8,9,23
//     {
//         int min = numbers[0];
//         foreach(int num in numbers)
//         {
//             if(num < min)
//                 min = num;
//         }

//         return min;
//     }

//     // Returning multiple values
//     public (int, int) CalculateMinMax(params int[] numbers)   // 4,6,1,8,9,23
//     {
//         int min = numbers[0];
//         int max = numbers[0];
//         foreach(int num in numbers)
//         {
//             if(num < min)
//                 min = num;
//             if(num > max)
//                 max = num;
//         }

//         return (min, max);      // Tuple
//     }
// }