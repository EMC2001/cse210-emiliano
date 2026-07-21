class Cycling : Activity
{
    private double _speed;

    public Cycling (double speed, int time, string date) : base (time, date)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetTime()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetActivity()
    {
        return "Cycling";
    }
}