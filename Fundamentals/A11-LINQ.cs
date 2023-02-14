using System;
using System.Collections.Generic;
using System.Linq;


// LINQ - Language Integrated Query 
// Technique to query collections (Array, List, dictionaries etc.)


class LINQ
{
    int[] scores = {2,3, 4, 1, 11, 15, 30, 66, 88, 500, 112, 12, 34 };

    public void LearnToQuery()
    {

        //Q1. Find all even numbers from scores 
        // Imperative way

        // List<int> evenNums = new();
        // foreach (int item in scores)
        // {
        //     if (item % 2 == 0)
        //     {
        //         evenNums.Add(item);
        //     }
        // }

        // Declarative way
        var evenNumbers = scores.Where(s => s % 2 == 0); //MethodSyntax

        // Expression Syntax
        evenNumbers = from s in scores
                      where s % 2 == 0
                      select s;
        var oddNumbers = scores.Where(s => s % 2 != 0);

        foreach (var num in evenNumbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        foreach (var num in oddNumbers)
        {
            Console.Write($"{num} ");
        }

        // Q3. Find multiple of 3 and 5 from scores

        Console.WriteLine();
        var multipleOF3And5 = scores.Where(s => s % 3 == 0 && s % 5 == 0);
        foreach (var num in multipleOF3And5)
        {
            Console.Write($"{num} ");
        }

        // Q4.Find squares of all numbers in scores

        Console.WriteLine();
        var squareOfAllNumbers = scores.Select(s => s * s);
        foreach (var num in squareOfAllNumbers)
        {
            Console.Write($"{num} ");
        }

        // Q5. Find squares of all nubers which are less than 50 from scores
        Console.WriteLine();
        var squareOFNumLess50 = scores.Where(s => s < 50).Select(s => s * s);
        squareOFNumLess50 = from s in scores
                            where s < 50
                            select s * s;

        foreach (var num in squareOFNumLess50)
        {
            Console.Write($"{num} ");
        }

        // Q6. Find cubes of all numbers in between 50 and 70
        Console.WriteLine();
        var cubesOfNumBet50And70 = scores.Where(s => s > 50 && s < 70).Select(s => s * s * s);
        cubesOfNumBet50And70 = from s in scores
                               where (s > 50 && s < 70)
                               select (s * s * s);
        foreach (var num in cubesOfNumBet50And70)
        {
            Console.Write($"{num} ");
        }


        // Q7. Find square roots of all numbers ending in 0 from scores

        Console.WriteLine("\nPrinting square roots of all numbers ending in 0");
        var squareRootEnding0 = scores.Where(s => s%10 == 0).Select(s => Math.Sqrt(s));
        foreach (var num in squareRootEnding0)
        {
            Console.Write($"{num} ");
        }

    }
}