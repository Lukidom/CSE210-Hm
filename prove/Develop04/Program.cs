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

                //  title and description variables
                
                int testVariable2 = 0;

                string reflectionTitle = "Reflection activity";
                string reflectionDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                
                string breathingTitle = "Breathing Activity";
                string breathingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

                string listingTitle = "Listing activity";
                string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

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
                ReflectionActivity reflectionActivity = new ReflectionActivity(reflectionTitle, reflectionDescription, testVariable2);

            }
            
            else if (response == 2)
            {
                // Listing exercise
                // instance for calling the ListingActivity constructor
                ListingActivity listingActivity = new ListingActivity(listingTitle, listingDescription, testVariable2);
                listingActivity.DisplayStartingMessage();

            }
            else if (response == 3)
            {
                // breathing exercise 
                BreathingActivity breathingActivity = new BreathingActivity(breathingTitle, breathingDescription, testVariable2);
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