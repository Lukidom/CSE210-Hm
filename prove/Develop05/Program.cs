using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        List<Goal> goalList = new List<Goal>();
        List<string> names = new List<string>();

        // Main menu 
        int choice = 0;



        // Create a simple goal
        Console.WriteLine("menu options: \n 1 - simple goal \n 2 - Checklist goal \n 3 - Eternal Goal 4 - Display goal List");
        choice = Int32.Parse(Console.ReadLine());
        if (choice == 1)
            {
                SimpleGoal simpleGoal = new SimpleGoal("Get better at push ups", "do tons of pushups", 50);
                goalList.Add(simpleGoal);

            }
        else if (choice == 2)
            {
            // Create a Checklist Goal
                CheckListGoal checkListGoal = new CheckListGoal("eat an apple", "Eat a bunch of apples", 15);
                goalList.Add(checkListGoal);
                
            }

        else if (choice == 3)
            {
                EternalGoal eternalGoal = new EternalGoal("increase faith", "read scriptures", 30);

            }
        else if (choice == 4)
            {

                foreach (Goal goal in goalList)
                {
                    Console.WriteLine(goal.GetString());
                }
            }

        // Get the strings one by one in a foreach loop (you'll need
        // to do this when you save each goal to a file)

    }
}