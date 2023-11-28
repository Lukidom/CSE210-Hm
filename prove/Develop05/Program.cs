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
        string choice = "";
        Console.Write("Select a choice from the menu: ");
        choice = Console.ReadLine();

        // Create a simple goal
        SimpleGoal simpleGoal = new SimpleGoal();
        goalList.Add(simpleGoal);

        // Create a Checklist Goal
        CheckListGoal checkListGoal = new CheckListGoal();
        goalList.Add(checkListGoal);

        // Goal goal = new Goal();

        // Get the strings one by one in a foreach loop (you'll need
        // to do this when you save each goal to a file)
        foreach (Goal goal in goalList)
        {
            Console.WriteLine(goal.GetString());
        }

    }
}