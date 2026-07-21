using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> activities = new List<Activity>();

        activities.Add(new Running(3.0, 30, "03 Nov 2026"));
        activities.Add(new Cycling());

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}