using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("nov 3", 30, 3.0);
        Console.WriteLine(running.CalculateDistance());
        Console.WriteLine(running.CalculateSpeed());
        Console.WriteLine(running.CalculatePace());
        Console.WriteLine(running.DisplaySummary());
        Console.WriteLine(running.GiveActivityType());
        
        Swimming swimming = new Swimming("Nov 3", 30, 3.0);
        Console.WriteLine(swimming.CalculateSpeed());
        Console.WriteLine(swimming.CalculateDistance());
        Console.WriteLine(swimming.CalculatePace());
        Console.WriteLine(swimming.DisplaySummary());
        Console.WriteLine(swimming.GiveActivityType());

        Cycling cycling = new Cycling("Nov 3", 30, 3.0);
        Console.WriteLine(cycling.CalculateDistance());
        Console.WriteLine(cycling.CalculateSpeed());
        Console.WriteLine(cycling.CalculatePace());
        Console.WriteLine(cycling.DisplaySummary());
        Console.WriteLine(cycling.GiveActivityType());



    }
}