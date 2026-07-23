class ChecklistGoal : Goal
{
    private int _checkedGoal;
    private int _attempts;
    private int _extraPoints;
    public ChecklistGoal(string goalName, string goalDescription, int points, bool completedGoal, int checkedGoal, int attempts, int extraPoints) : base (goalName, goalDescription, points, completedGoal)
    {
        _checkedGoal = checkedGoal;
        _attempts = attempts;
        _extraPoints = extraPoints;
    }

    public override int RecordEvent()
    {
        _checkedGoal++;
        if (_checkedGoal >= _attempts)
        {
            return GetGoalPoints() + _extraPoints;
        }

        return GetGoalPoints();
    }
}