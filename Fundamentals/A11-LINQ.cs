// using System;
// using System.Collections.Generic;
// using System.Linq;


// // LINQ - Language Integrated Query 
// // Technique to query collections (Array, List, dictionaries etc.)


// class LINQ
// {
//     int[] scores = { 2, 3, 4, 1, 11, 15, 30, 66, 88, 500, 112, 12, 34 };
//     string[] names = { "Samuel", "Subu", "Anmol", "Damak", "Pops" };

//      List<Person> people = new()
//     {
//         new Person(){Natioanality="Nepal", Name = "Ram Ji", Dob = new DateTime(1998, 12, 13)},
//         new Person(){Natioanality="China", Name = "Ajaya", Dob = new DateTime(2010, 1, 13)},
//         new Person(){Natioanality="India", Name = "Krishna", Dob = new DateTime(1988, 2, 23)},
//         new Person(){Natioanality="USA", Name = "Anirudra", Dob = new DateTime(1978, 3, 1)},
//         new Person(){Natioanality="India", Name = "Kishan", Dob = new DateTime(1990, 4, 13)},
//         new Person(){Natioanality="Nepal", Name = "Roshan", Dob = new DateTime(2008, 10, 29)},
//     };

//     public void LearnToQuerySelectAndWhere()
//     {
//         Dictionary<string, long> countryPopulation = new();
//         countryPopulation.Add("Nepal", 31134323);
//         countryPopulation.Add("India", 127398217498);
//         countryPopulation.Add("China", 123802342434);
//         countryPopulation.Add("USA", 3802342434);
//         countryPopulation.Add("Germany", 22342434);
//         countryPopulation.Add("Canada", 12342434);

//         //Q1. Find all even numbers from scores 
//         // Imperative way

//         // List<int> evenNums = new();
//         // foreach (int item in scores)
//         // {
//         //     if (item % 2 == 0)
//         //     {
//         //         evenNums.Add(item);
//         //     }
//         // }

//         // Declarative way
//         var evenNumbers = scores.Where(s => s % 2 == 0); //MethodSyntax

//         // Expression Syntax
//         evenNumbers = from s in scores
//                       where s % 2 == 0
//                       select s;
//         var oddNumbers = scores.Where(s => s % 2 != 0);

//         foreach (var num in evenNumbers)
//         {
//             Console.Write($"{num} ");
//         }
//         Console.WriteLine();
//         foreach (var num in oddNumbers)
//         {
//             Console.Write($"{num} ");
//         }

//         // Q3. Find multiple of 3 and 5 from scores

//         Console.WriteLine();
//         var multipleOF3And5 = scores.Where(s => s % 3 == 0 && s % 5 == 0);
//         foreach (var num in multipleOF3And5)
//         {
//             Console.Write($"{num} ");
//         }

//         // Q4.Find squares of all numbers in scores

//         Console.WriteLine();
//         var squareOfAllNumbers = scores.Select(s => s * s);
//         foreach (var num in squareOfAllNumbers)
//         {
//             Console.Write($"{num} ");
//         }

//         // Q5. Find squares of all nubers which are less than 50 from scores
//         Console.WriteLine();
//         var squareOFNumLess50 = scores.Where(s => s < 50).Select(s => s * s);
//         squareOFNumLess50 = from s in scores
//                             where s < 50
//                             select s * s;

//         foreach (var num in squareOFNumLess50)
//         {
//             Console.Write($"{num} ");
//         }

//         // Q6. Find cubes of all numbers in between 50 and 70
//         Console.WriteLine();
//         var cubesOfNumBet50And70 = scores.Where(s => s > 50 && s < 70).Select(s => s * s * s);
//         cubesOfNumBet50And70 = from s in scores
//                                where (s > 50 && s < 70)
//                                select (s * s * s);
//         foreach (var num in cubesOfNumBet50And70)
//         {
//             Console.Write($"{num} ");
//         }


//         // Q7. Find square roots of all numbers ending in 0 from scores

//         Console.WriteLine("\nPrinting square roots of all numbers ending in 0");
//         var squareRootEnding0 = scores.Where(s => s % 10 == 0).Select(s => Math.Sqrt(s));
//         foreach (var num in squareRootEnding0)
//         {
//             Console.Write($"{num} ");
//         }



//         // Q8. Get uppercase equivalent  of all names and sort them in ascending order
//         Console.WriteLine();
//         var uppercaseNames = names.Select(s => s.ToUpper()).OrderBy(s => s);
//         foreach (var name in uppercaseNames)
//         {
//             Console.Write($"{name} ");
//         }

//         // Q9. List Country names,
//         Console.WriteLine();
//         var countryNames = countryPopulation.Select(n => n.Key);
//         foreach (var name in countryNames)
//         {
//             Console.Write($"{name} ");
//         }

//         //  list all countries in ascending order of their population.
//         Console.WriteLine();
//         var countriesWithPopluationAscending = countryPopulation.OrderBy(n => n.Value).Select(n => n.Key);
//         foreach (var name in countriesWithPopluationAscending)
//         {
//             Console.Write($"{name} ");
//         }
//     }

//     public void LearnToQueryOthers()
//     {
//         // Find if scores contains any even number

//         var containEvenNumber = scores.Any(x => x % 2 == 0);


//         // Find if scores contains all even number

//         var containEvenNumberAll = scores.All(x => x % 2 == 0);

//         // Get first 3 elements from scores

//         var first3Number = scores.Take(3);

//         var escapeFirst5 = scores.Skip(5).Take(3);

//     }

//     public void LearnTOQueryComplexCollections()
//     {
//         // Find all people who can vote
//         // find names of all people who can vote
//         Console.WriteLine();
//         var whoCanVote = people.Where(a => a.Dob>= 18).Select(n => n.name);
//         foreach (var item in whoCanVote)
//         {
//             Console.WriteLine(item);
//         }

//         // Expression syntax
//         DateTime todayDate = DateTime.Now;
//         var voteList = from person in people
//                        where (person.dob - todayDate) >= 18
//                        select person.name;

//         foreach (var item in whoCanVote)
//         {
//             Console.WriteLine(item);
//         }
//         // ctrl + Alt + down arrow


//         // 

//     }
// }





// LINQ - Language Integrated Query
// Technique to query collections (Array, List, dictionaries etc.)

using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] scores = { 3, 4, 5, 6, 12, 34, 15, 230, 56, 13, 870, 98, 93, 231, 342 };
    string[] names = { "Ram Karki", "ELton John", "Balen Shah", "Baburam Bhattarai" };
    Dictionary<string, long> countryPopulation = new()
    {
        ["Nepal"] = 9837498,
        ["India"] = 127398217498,
        ["China"] = 123802342434,
        ["USA"] = 3802342434,
        ["Germany"] = 22342434,
        ["Canada"] = 12342434
    };
    List<Person> people = new()
    {
        new Person(){EducationDegreeId =1 ,Natioanality="Nepal", Name = "Ram Ji", Dob = new DateTime(1998, 12, 13)},
        new Person(){EducationDegreeId = 2,Natioanality="China", Name = "Ajaya", Dob = new DateTime(2010, 1, 13)},
        new Person(){EducationDegreeId = 3,Natioanality="India", Name = "Krishna", Dob = new DateTime(1988, 2, 23)},
        new Person(){EducationDegreeId = 1,Natioanality="USA", Name = "Anirudra", Dob = new DateTime(1978, 3, 1)},
        new Person(){EducationDegreeId = 2,Natioanality="India", Name = "Kishan", Dob = new DateTime(1990, 4, 13)},
        new Person(){EducationDegreeId = 3,Natioanality="Nepal", Name = "Roshan", Dob = new DateTime(2008, 10, 29)},
    };
    List<EducationDegree> degrees = new()
    {
new() {Id = 1, Major = "Science", Title = "M.sc.",University = "TU"},
new() {Id = 2, Major = "Arts", Title = "MA",University = "KU"},
new() {Id = 3, Major = "Education", Title = "Med",University = "TU"},
    };
    public void LearnToQuerySelectAndWhere()
    {
        // Q1. Find all even numbers from scores
        // Method syntax
        var evenNumbers = scores.Where(s => s % 2 == 0);

        // Expression syntax
        evenNumbers = from s in scores
                      where s % 2 == 0
                      select s;

        // Q2. Find all odd numbers from scores
        var oddNumbers = scores.Where(s => s % 2 != 0);

        // Q3. Find multiples of 3 and 5 from scores
        var multiplesOf3And5 = scores.Where(s => s % 3 == 0 && s % 5 == 0);

        // Q4. Find squares of all numbers in scores
        var squares = scores.Select(s => s * s);

        // Q5. Find squares of all numbers which are less than 50 from scores
        var squaresLessThan50 = scores.Where(s => s < 50).Select(s => s * s);

        squaresLessThan50 = from s in scores
                            where s < 50
                            select s * s;

        // Q6. Find cubes of all numbers in between 50 and 70 from scores
        // Q7. Find square roots of all numbers ending in 0 from scores
        // Q8. Get uppercase equivalent of all names and sort them in ascending order
        var uNames = from name in names
                     orderby name
                     select name.ToUpper();


        // Q.9. List all country names
        // Q 10.List all countries in descending order of their population

        var countryNames = countryPopulation.Select(c => c.Key);
        var countriesSorted = from c in countryPopulation
                              orderby c.Value
                              select c;

        foreach (var num in squares)
        {
            Console.Write($"{num} ");
        }
    }
    public void LearnToQueryOthers()
    {
        // Quntification: Any, All
        // Q 11. Find if scores contains any even number
        var containEvenNumber = scores.Any(x => x % 2 == 0);
        var containAnyElement = scores.Any();

        // Q 12. Find if scores has all even numbers
        var allEvenNumbers = scores.All(x => x % 2 == 0);

        // Partitioning: skip and take
        // Get first 3 elements from scores
        var x = scores.Take(3);

        // Skip frist 5 and take next 3
        var y = scores.Skip(5).Take(3);
    }
    public void LearnTOQueryComplexCollections()
    {
        // Q. 13 Find names of people who can vote
        // fix this

        var voteList = from p in people
                       where (((DateTime.Now - p.Dob).TotalDays / 365) >= 18)
                       select p.Name;

        // Q 14. Find all nepalese people who born after .NET is released

        var z = from p in people
                where p.Natioanality == "Nepal" && p.Dob.Year > 2002
                select p.Name;



        // Q 15. Find all people names and correspoding degree title who has science major

        var peopleDegree = from student in people
                           join deg in degrees on student.EducationDegreeId equals deg.Id
                           where deg.Major == "Science"
                           select (student.Name, deg.Title);



        // Q16. Find all indians who are doing arts. Print all people and their education dtails. 

        var indiansArts = from student in people
                          join deg in degrees on student.EducationDegreeId equals deg.Id
                          where (student.Natioanality == "India" && deg.Major == "Arts")
                          select (student.Name, deg.Major, deg.Title, deg.University);

        foreach (var item in indiansArts)
        {
            Console.WriteLine(item);
        }
    }
}