public class EternalGoal : Goal 
{

    public EternalGoal(string name, string description, int pointValue) : base (name, description, pointValue)
    {

    }



    public override string GetGoalType()
    {
        return "EternalGoal";
    }
    // cannot be completed need to be overwridden. 
}
