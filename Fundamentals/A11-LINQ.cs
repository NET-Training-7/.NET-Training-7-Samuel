using System;
using System.Collections.Generic;
using System.Linq;


// LINQ - Language Integrated Query 
// Technique to query collections (Array, List, dictionaries etc.)


class LINQ
{
    int[] scores = { 2, 3, 4, 1, 11, 15, 30, 66, 88, 500, 112, 12, 34 };
    string[] names = { "Samuel", "Subu", "Anmol", "Damak", "Pops" };

    public void LearnToQuerySelectAndWhere()
    {
        Dictionary<string, long> countryPopulation = new();
        countryPopulation.Add("Nepal", 31134323);
        countryPopulation.Add("India", 127398217498);
        countryPopulation.Add("China", 123802342434);
        countryPopulation.Add("USA", 3802342434);
        countryPopulation.Add("Germany", 22342434);
        countryPopulation.Add("Canada", 12342434);

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
        var squareRootEnding0 = scores.Where(s => s % 10 == 0).Select(s => Math.Sqrt(s));
        foreach (var num in squareRootEnding0)
        {
            Console.Write($"{num} ");
        }



        // Q8. Get uppercase equivalent  of all names and sort them in ascending order
        Console.WriteLine();
        var uppercaseNames = names.Select(s => s.ToUpper()).OrderBy(s => s);
        foreach (var name in uppercaseNames)
        {
            Console.Write($"{name} ");
        }

        // Q9. List Country names,
        Console.WriteLine();
        var countryNames = countryPopulation.Select(n => n.Key);
        foreach (var name in countryNames)
        {
            Console.Write($"{name} ");
        }

        //  list all countries in ascending order of their population.
        Console.WriteLine();
        var countriesWithPopluationAscending = countryPopulation.OrderBy(n => n.Value).Select(n => n.Key);
        foreach (var name in countriesWithPopluationAscending)
        {
            Console.Write($"{name} ");
        }
    }

    public void LearnToQueryOthers()
    {
        // Find if scores contains any even number

        var containEvenNumber = scores.Any(x => x % 2 == 0);


        // Find if scores contains all even number

        var containEvenNumberAll = scores.All(x=> x%2 ==0);

        // Get first 3 elements from scores

        var first3Number = scores.Take(3);

        var escapeFirst5 = scores.Skip(5).Take(3);

    }
}