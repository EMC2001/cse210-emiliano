class ChecklistGoal : Goal
{
    private int _checkedGoal;
    public ChecklistGoal(string goalName, string goalDescription, int points, bool completedGoal, int checkedGoal) : base (goalName, goalDescription, points, completedGoal)
    {
        _checkedGoal = checkedGoal;
    }
}