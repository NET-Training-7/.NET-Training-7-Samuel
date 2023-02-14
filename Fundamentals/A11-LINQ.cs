using System;
using System.Collections.Generic;
using System.Linq;


// LINQ - Language Integrated Query 
// Technique to query collections (Array, List, dictionaries etc.)


class LINQ
{
    int[] scores = { 3, 4, 1, 11, 66, 88, 516, 112, 12, 34 };

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
        var evenNumbers = scores.Where(s => s % 2 == 0);
        var oddNumbers = scores.Where(s => s % 2 != 0);

        foreach (var item in evenNumbers)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        foreach (var item in oddNumbers)
        {
            Console.Write($"{item} ");
        }

    }
}