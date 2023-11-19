using System;
using System.Formats.Asn1;
using System.IO.Enumeration;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)

    //  Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.

        {
            string filename = "Alma 18_27.txt";

            StreamReader userScripture = new StreamReader(filename);
            string[] WordsInScipture = userScripture.ReadLine().Split(' ');
            userScripture.Close();


            Word[] words = new Word[WordsInScipture.Length];
            for (int i = 0; i < WordsInScipture.Length; i++)
            {
                words[i] = new Word(WordsInScipture[i]);
            }
            string input = "";

            while (input != "quit")
                {
                Random random = new Random();
                words[random.Next(words.Length)].Hide();
                Console.Clear();
                for (int i = 0; i < words.Length; i++)
                {
                    Console.Write(words[i].GetWord() + " ");
                }
                input = Console.ReadLine();

                }




    }
        
}


