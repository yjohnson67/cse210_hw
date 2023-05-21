using System;
using System.Collections.Generic;

public class Activity
{
    // Protected field to store the date of the activity
    protected DateTime date;
    // Protected field to store the length of the activity in minutes
    protected int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public virtual double GetDistance()
    {
        // Default implementation returns 0 for activities without a specific distance calculation
        return 0;
    }

    public virtual double GetSpeed()
    {
        // Default implementation returns 0 for activities without a specific speed calculation
        return 0;
    }

    public virtual double GetPace()
    {
        // Default implementation returns 0 for activities without a specific pace calculation
        return 0;
    }

    public string GetSummary()
    {
        // Generate a summary string for the activity, including the date, activity type, length, distance, speed, and pace
        string summary = $"{date.ToShortDateString()} {GetType().Name} ({length} min) - ";
        summary += $"Distance: {GetDistance()} miles, ";
        summary += $"Speed: {GetSpeed()} mph, ";
        summary += $"Pace: {GetPace()} min per mile";

        return summary;
    }
}