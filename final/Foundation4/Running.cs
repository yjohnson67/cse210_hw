public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / length * 60; // mph
    }

    public override double GetPace()
    {
        return length / distance; // min per mile
    }
}