public class Running : Activity
{
    // Private field to store the distance of the running activity in miles
    private double distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        //Return the distance of the running activity in miles
        return distance;
    }

    public override double GetSpeed()
    {
        // Calculate the speed in miles per hour based on the distance and the total time (length) of the running activity
        return distance / length * 60; // mph
    }

    public override double GetPace()
    {
        // Calculate the pace in minutes per mile based on the total time (length) and the distance of the running activity
        return length / distance; // min per mile
    }
}