class Swimming : Activity
{
    private int _laps;

    public Swimming (int laps, int time, string date) : base (time, date)
    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public override double GetDistance()
    {
        return (_laps*50) /1000;
    }

    public override double GetPace()
    {
        return GetTime()/GetDistance();
    }

    public override double GetSpeed()
    {
        return (GetDistance()/GetTime() * 60);
    }
}