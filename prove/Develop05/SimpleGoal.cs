class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDescription, int points, bool completedGoal) : base (goalName, goalDescription, points, completedGoal)
    {

    }

    public override int RecordEvent()
    {
        CompleteGoal();

        return GetGoalPoints();
    }
}