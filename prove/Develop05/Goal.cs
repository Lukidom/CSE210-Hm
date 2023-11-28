public abstract class Goal 
{
    // Protected variables are accessible by itself and its children
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected bool _completed;

    public virtual string GetString()
    {
        string returnString = $"{GetType()},{_name},{_description},{_pointValue},{_completed}";
        return returnString;
    }

    public abstract string GetGoalType(); 
}