public class Swimming : Activity
{
    // Private field to store thenumber of laps swam
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // Calculate the distance swam in miles based on the number of laps (assuming 50 meters per lap), converting to miles (0.62 miles per kilometer)
        return laps * 50 / 1000 * 0.62; // miles
    }

    public override double GetSpeed()
    {
        // Calculate the speed in miles per hour based on the distance and the total time (length) of the swimming activity
        return GetDistance() / length * 60; // mph
    }

    public override double GetPace()
    {
        // Calculate the pace in minutes per mile based on the total time (length) and the distance of the swimming activity
        return length / GetDistance(); // min per mile
    }
}