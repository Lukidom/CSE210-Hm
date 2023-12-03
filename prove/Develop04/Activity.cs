

public class Activity
{
    // Protected member variables
    protected string _nameActivity;

    protected string _description;

    protected int _duration;
    
    // class constructor
    public Activity()
    {
        Console.WriteLine("testing");
    }
    public Activity(string nameActivity, string description, int duration)
    {
        _description = description;
        _duration = duration;
        _nameActivity = nameActivity;
    }

    // displays starting messages and askes user for activity duration
    public void DisplayStartingMessage()
    {
    Console.WriteLine($"{_nameActivity} - {_description}");
    int userTimer = Convert.ToInt32(Console.ReadLine());
    _duration = userTimer;
    }
    
    // Displays ending message after activity is complete
    public void DisplayEndingMessage()
    {
        Console.WriteLine("ending message here");
    }

    // Displays timer and animation of time given by user in DisplayStartingMessage()
    public void DisplayTimer()
    {   
        // Console.WriteLine("input time desired: ");
        // int userTimer = Convert.ToInt32(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
   
        while (DateTime.Now < futureTime)
        {
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write("\b \b");
            Console.Write(":");
        }
    }
    

}

