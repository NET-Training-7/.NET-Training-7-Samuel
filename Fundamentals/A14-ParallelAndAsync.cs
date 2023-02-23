
// Parallel Programming
// Multhreading  - Creating threads manualy
// Tasks - Task Parallel Library (TPL)
// Requirements: 
// Computation for each item should be independent
// Each computation takes some time (>200ms) 

using System;
using System.Diagnostics;
using System.Threading.Tasks;

class ParallelProgramming
{
    double[] numbers = { 3.5, 6.7, 21.3, 45.6, 23.1, 22.56, 89.01, 44.56, 89.01, 44.56, 67.34, 67.123 };

    public void ComputeSquareRoots()
    {
        // Sequential 
        Stopwatch sw = Stopwatch.StartNew();
        Console.WriteLine("Sequential Version");

        foreach (var num in numbers)
        {
            CalculateSR(num);
        }
        Console.WriteLine($"It took:{sw.ElapsedMilliseconds} ms.");

        // Parallel
        sw.Restart();
        Console.WriteLine("Parallel Version");
        Parallel.ForEach(numbers, (num) =>
        {
            CalculateSR(num);
        });

        void CalculateSR(double num)
        {
            // Thread.Sleep(10);
            var sq = Math.Sqrt(num);
            Console.WriteLine($"Square root of {num} is {sq}");
        } 
    }
}


// Asynchronous Programming
// Ajax - Asynchronous JavaScript And XML
// C# - Non-blocking IO, async await

class AsyncProramming
{
    public async Task<bool> Calculate()
    {
        await Calculate1();
        await Calculate2();
        await Calculate3();
        return true;
    }

    public async Task Calculate1()
    {
        await Task.Delay(1000);
    }
    public async Task Calculate2()
    {
        await Task.Delay(1000);
    }
    public async Task Calculate3()
    {
        await Task.Delay(1000);
    }
}