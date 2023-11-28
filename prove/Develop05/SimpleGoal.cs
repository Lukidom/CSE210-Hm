public class SimpleGoal : Goal
{
    public void SetName(string name)
    {
        _name = name;
    }

    public override string GetGoalType()
    {
        return "SimpleGoal";
    }
}