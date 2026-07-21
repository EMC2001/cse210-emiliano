class Activity
{
    private int _time;
    private string _date;

    public Activity (int time, string date)
    {
        _time = time;
        _date = date;
    }

    public virtual double GetDistance()
    {
        double distance = 0;
        return distance;
    }

    public virtual double GetSpeed()
    {
        double speed = 0;
        return speed;
    }

    public virtual double GetPace()
    {
        double pace = 0;
        return pace;
    }

    public int GetTime()
    {
        return _time;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual string GetActivity()
    {
        return "";
    }

    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetActivity()} ({GetTime()} min)- Distance {GetDistance()} kilometers, Speed {GetSpeed()} kph, Pace {GetPace()} min per kilometer.";
    }
}