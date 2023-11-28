public class CheckListGoal : Goal
{
    protected int _repsRequired;
    protected int _repsCompleted;
    protected int _bonusPoints;

    public override string GetString()
    {
        string returnString = base.GetString();
        returnString += ($",{_repsRequired},{_repsCompleted},{_bonusPoints}");
        
        return returnString;        
    }

    public override string GetGoalType()
    {
        return "CheckListGoal";
    }
    // reps need to be completed to be marked as complete
}