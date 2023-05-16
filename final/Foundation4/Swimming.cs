public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62; // miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / length * 60; // mph
    }

    public override double GetPace()
    {
        return length / GetDistance(); // min per mile
    }
}