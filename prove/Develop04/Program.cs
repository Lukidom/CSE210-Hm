using System;
using System.Net;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
        Activity masteractivity = new Activity();

        string userResponse = "";

        Console.Clear();

        while (userResponse != "5")
        {

                string testVariable = "name of activity here";
                string testVariable1 = "description of activity here";
                int testVariable2 = 0;

            Activity activity = new Activity();
        // activity.DisplayEndingMessage();
        // ending message displays after activity is complete
            Console.WriteLine("Welcome to Luke's Mindfulness program \n choose one of these options to begin \n 1 - Reflecting Activity \n 2 - Listing Activity \n 3 - Breathing Activity \n 4 - Quit ");
            userResponse = Console.ReadLine();
            int response = int.Parse(userResponse);
            if (response == 1)
            {
                // Reflection exercise
                // instance for reflectionActivity
                // reflectionActivity.DisplayStartingMessage();
                ReflectionActivity reflectionActivity = new ReflectionActivity("reflection activity test", "test", 5);

            }
            
            else if (response == 2)
            {
                // Listing exercise
                // instance for calling the ListingActivity constructor
                ListingActivity listingActivity = new ListingActivity(testVariable, testVariable1, testVariable2);
                // listingActivity.DisplayStartingMessage();

            }
            else if (response == 3)
            {
                // breathing exercise 
                BreathingActivity breathingActivity = new BreathingActivity(testVariable, testVariable1, testVariable2);
                breathingActivity.DisplayStartingMessage();
                breathingActivity.GetDuration(0);
                breathingActivity.DisplayBreathingMessage();

            }
            else if (response == 4)
            {
                // end of preogram
            }

            

            // Testing and working with time. 
            // activity.DisplayTimer();




            }



    }
}