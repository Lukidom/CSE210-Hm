using System;
using System.Globalization;


public class ReflectionActivity : Activity
{
    string[] prompts = {"think of when you had a defining moment", "Think of a time when you did something difficult", "think of when you have helped someone in need"};
    string[] questions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};



    public ReflectionActivity() : base()
    {

    }
    public ReflectionActivity(string nameActivity, string description, int duration) : base(nameActivity, description, duration)
    {

    }
   
    // for loop for printing elements of array
    public void DisplayPrompts()
    {   
        Random random = new Random();
    
        for (int i = 0; i < prompts.Length; i++)
        {
            int indexToPrint = random.Next(0, prompts.Length);
            Console.WriteLine($"==> {prompts[indexToPrint]}");
            break;
        }
        Thread.Sleep(5000);

        for (int i = 0; i < questions.Length; i++)
        {
            int indexToPrint = random.Next(0, prompts.Length);
            Console.WriteLine($"==> {prompts[indexToPrint]}");
            break;
        }
    }
    
}