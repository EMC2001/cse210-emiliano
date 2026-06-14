class Activity
{
    private string _activityDescription;

    public Activity(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public string GetActivity()
    {
        return $"{_activityDescription}";
    }

        
}