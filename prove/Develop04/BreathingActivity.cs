using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        
    }
    public BreathingActivity(string nameActivity, string description, int duration) : base(nameActivity, description, duration)
    {

    }

    int _timeDuration;

    public void GetDuration(int timeDuration)
    {

        _timeDuration = timeDuration; 
    }

    
    public void DisplayBreathingMessage()
    {
        while (_timeDuration < _duration)
        {
                // need to fix this somehow. isnt running as well as i would like. 
            Thread.Sleep(2000);
            Console.WriteLine("breathe in..");
            Thread.Sleep(2000);
            Console.WriteLine("breathe out..");
            DisplayTimer();
            _timeDuration++;
        }
    }
    
}
