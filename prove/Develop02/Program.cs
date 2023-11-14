//  Luke Ramirez(Lucas)
//  program - Journal - programming with classes 210 


using System;
using System.Net;
// using Journal;


class Program+
{
    static void Main(string[] args)
    {
        //  print menu options
        Console.WriteLine("Please select one of these options.\n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
        string userResponse = Console.ReadLine();
        int response = int.Parse(userResponse);

    

        // Block of if statements
        // if () ? x : y
        
        if (response == 1)
        {
            Entry entry = new Entry();
        // entry.userResponse = "temporary";
        // entry.Date = "temporary";
        entry.DateForJournal(); 
        entry.displayUserPrompt();
        entry.MakeEntry();++++++++++++++++
        displayMenu();

        
        }

        else if (response == 2)
        {
            // display previous Journal 
        }

        else if (response == 3)
        {
            Console.WriteLine("What is the file name?");
            string nameOfFile = Console.ReadLine();
            Journal journal = new Journal();
            journal.LoadJournalEntry();
            displayMenu();
            // load previous journal entry
        }
        else if (response == 4)
        {
            Journal journal1 = new Journal();
            journal1.SaveJournalEntry();
            displayMenu();
            // Save journal entry

        }
        else if (response == 5)
        {
            // Quit
        }
        else
        {
            Console.WriteLine("That does not work. ");
            displayMenu();
            // quit
        }
        

        // Journal journal = new Journal();
        // journal.IterateListEntry();
        // // journal.LoadJournalEntry();
        // journal.SaveJournalEntry();

    }
    static void displayMenu()
    {
    Console.WriteLine("Please select one of these options.\n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
        string userResponse = Console.ReadLine();
        int response = int.Parse(userResponse);

    }

}