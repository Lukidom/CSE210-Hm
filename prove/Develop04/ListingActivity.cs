using System;

public class ListingActivity : Activity

// listing activity. User is given a promt and makes list of things. things one is grateful for etc..
{
    public string _userResponse;

    public ListingActivity() : base()
    {
        
    }
    public ListingActivity(string nameActivity, string description, int duration) : base(nameActivity, description, duration)
    {

    }
    
    // Base part again

    // Displays prompt for listing exercise 
    public void DisplayPrompt()
    {

    }
}