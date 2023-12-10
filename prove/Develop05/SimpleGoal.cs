public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int pointValue) : base (name, description, pointValue)
    {

    }
    public void SetName(string name)
    {
        _name = name;
    }

    public override string GetGoalType()
    {
        return "";
    }
}