using System;
using System.IO;

public class Journal
{
    // public List JournalList;
    // string JournalList[temp]
    


    public void SaveJournalEntry()
    {
        // saves entry to file

        string fileName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("temporary");

        }
    }

    public void DisplayJournalEntry()
    {

    }

    public void LoadJournalEntry()
    {
        // Reads entry from file
         
        // string givenFile = Console.ReadLine();
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            String firstname = parts[0];
            string lastname = parts [1];
        }
    }
    

}