//  Luke Ramirez(Lucas)
//  program - Journal - programming with classes 210 


using System;
using System.Net;
// using Journal;


class Program
{
    static void Main(string[] args)
    {
        Journal masterJournal = new Journal(); // Global variable 

        string userResponse = "";

        Console.Clear(); // makes the terminal nice and clean
        while (userResponse != "5")
        {
            //  print menu options
            Console.WriteLine("Please select one of these options.\n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            userResponse = Console.ReadLine();
            int response = int.Parse(userResponse);

            // Write
            if (response == 1)
            {
                Entry entry = new Entry();
                // entry.userResponse = "temporary";
                // entry.Date = "temporary";
                entry.DateForJournal(); 
                entry.displayUserPrompt();
                entry.MakeEntry();
                masterJournal._entries.Add(entry);
            }
            // Display 
            else if (response == 2)
            {
                // display previous Journal 
            }
            // Load
            else if (response == 3)
            {
                Console.WriteLine("What is the file name?");
                string nameOfFile = Console.ReadLine();
                masterJournal.LoadJournalEntry();
                // load previous journal entry
            }
            // Save
            else if (response == 4)
            {
                masterJournal.SaveJournalEntry();
            }
            else
            {
                Console.WriteLine("That does not work. ");
            }

        }
        

        // Journal journal = new Journal();
        // journal.IterateListEntry();
        // // journal.LoadJournalEntry();
        // journal.SaveJournalEntry();

    }
    // static void displayMenu()
    // {
    // Console.WriteLine("Please select one of these options.\n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
    //     string userResponse = Console.ReadLine();
    //     int response = int.Parse(userResponse);

    // }

}