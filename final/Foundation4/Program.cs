using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> activities = new List<Activity>();

        activities.Add(new Running(3.0, 30, "03 Nov 2026"));
        activities.Add(new Cycling(5.0, 45, "04 Nov 2026"));
        activities.Add(new Swimming(50, 60, "05 Nov 2026"));

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}