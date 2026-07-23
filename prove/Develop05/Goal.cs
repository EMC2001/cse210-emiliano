class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _points;
    private bool _completedGoal;


    public Goal(string goalName, string goalDescription, int points, bool completedGoal)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
        _completedGoal = completedGoal;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public virtual int GetGoalPoints()
    {
        return _points;   
    }

    public virtual bool GetCompletedGoal()
    {
        return _completedGoal;
    }

    public void CompleteGoal()
    {
        _completedGoal = true;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }
}
