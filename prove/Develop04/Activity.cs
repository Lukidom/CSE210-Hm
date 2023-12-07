

public class Activity
{
    // Protected member variables
    protected string _nameActivity;

    protected string _description;

    protected int _duration;
    
    // class constructor
    public Activity()
    {

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
    Console.WriteLine("how long would you like the activity to be?");
    int userTimer = Convert.ToInt32(Console.ReadLine());
    _duration = userTimer;
    }
    
    // Displays ending message after activity is complete
    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("end program \n (press any key to exit)");
        Console.ReadKey();
        Environment.Exit(0);
        Console.Clear();

    }

    // Displays timer and animation timer given by user in DisplayStartingMessage()
    public void DisplayTimer()
    {   
        // Console.WriteLine("input time desired: ");
        // int userTimer = Convert.ToInt32(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
   
        while (DateTime.Now < futureTime)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\r-");
            Thread.Sleep(250);
            Console.Write("\r-\\");
            Thread.Sleep(250);
            Console.Write("\r-|");
            Thread.Sleep(250);
        }
        Console.WriteLine("\nTimes up! ");
    }
    

}

