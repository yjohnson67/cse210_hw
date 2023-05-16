using System;
using System.Collections.Generic;

public class Activity
{
    protected DateTime date;
    protected int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        string summary = $"{date.ToShortDateString()} {GetType().Name} ({length} min) - ";
        summary += $"Distance: {GetDistance()} miles, ";
        summary += $"Speed: {GetSpeed()} mph, ";
        summary += $"Pace: {GetPace()} min per mile";

        return summary;
    }
}