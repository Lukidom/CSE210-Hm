using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace lukeSpace
{
    public class Program
    {
        public Program()
        {
            // constructor
        }

        static void Main(string[] args)
        {
            // In your Program.cs file, verify that you can call all of these methods and get the correct values, using setters to change the values and then getters to retrieve these new values and then display them to the console.
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetFractionDecimal());

        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetFractionDecimal());
            
        Fraction fraction2 = new Fraction(3, 4);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetFractionDecimal());
        }

    }
}

