using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumberGenerator = new Random();
        int magic = randomNumberGenerator.Next(1, 101);
        int guess = -1;
        while (guess != magic)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            Console.WriteLine(guess);
            if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}