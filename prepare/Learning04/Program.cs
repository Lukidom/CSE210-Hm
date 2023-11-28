 using System;

class Program
{
    static void Main(string[] args)

    {
        Base base1 = new Base();
        base1.GetStudentNameandtopic("charles", "math");
        Console.WriteLine(base1.GetSummary());
        Math math = new Math();
        Console.WriteLine(math.GetHomeWork("section 4", "1-30"));
        English english = new English();
        english.GetStudentNameandtopic("Mary alice", "english");
        Console.WriteLine(english.GetWritingInformation("The great depression"));




 
   }
}