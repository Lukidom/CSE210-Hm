public class Goal 
{
    // Protected variables are accessible by itself and its children
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected bool _completed;

    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;

    }
    public virtual string GetString()
    {
        string returnString = $"{GetType()},{_name},{_description},{_pointValue},{_completed}";
        return returnString;
    }

    public virtual string GetGoalType()
    {
        return "goaltype";
    }
    public void AddPoints()
    {
        
    }

    public void DisplayCurrentGoal()
    {

    }
    public void DisplayGoal()
    {

    }

    public void ListGoals()
    {

    }

    public void SaveGoal()
    {

    }

    public void LoadGoal()
    {

    }
    
}