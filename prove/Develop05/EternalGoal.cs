class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int points, bool completedGoal) : base (goalName, goalDescription, points, completedGoal)
    {

    }

    public override int RecordEvent()
    {
            return GetGoalPoints();
    }
}