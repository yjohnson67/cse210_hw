public class Cycling : Activity
{
    // Private field to store the speed in miles per hour
    private double speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        // Return the speed in miles per hour
        return speed;
    }

    public override double GetDistance()
    {
        // Calculate the distance traveled in miles based on the speed and the total time (length) of the cycling activity
        return speed * length / 60; // miles
    }

    public override double GetPace()
    {
        // Calculate the pace in minutes per mile based on the speed of the cycling activity
        return 60 / speed; // min per mile
    }
}