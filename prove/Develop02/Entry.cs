using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


    public class Entry
{
    public string userResponse;

    public string prompt;

    public string[] records;

    public string currentRecord;
    public int Date;
    // This is a constructor  figure it out. 
    public Entry()
    {
        
    
    }



    // method to display journal prompt. 
    public void displayUserPrompt()
    {
        Random random = new Random();

        string[] prompts = {"happy memory", "someone you met", "perfect moment", "Something you don't want to forget"};
        Console.WriteLine(prompts[random.Next(0, prompts.Length)]);

        
        // foreach (string i in prompts)
        // Console.WriteLine(i);
    }
    public void MakeEntry()
    {
        Console.WriteLine(">>");
       string userEntry = Console.ReadLine();
       
        records = new string[] {userEntry};
    }
    public void DateForJournal()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(dateText);

    }

}

// /* you have to take the file from the var and connect it to the write file. /




