using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void SaveJournalEntry()
    {
        // saves entry to file

        string fileName = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.date},{entry.userResponse}");
            }
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
            // Split up the string
            string[] parts = line.Split(",");
            string date            = parts[0];
            string userResponse = parts [1];

            // Create a new entry for each line
            Entry entry = new Entry();
            entry.userResponse = userResponse;
            entry.date = date;

            // Add entry to the journal list
            _entries.Add(entry);
        }
    }
    

}