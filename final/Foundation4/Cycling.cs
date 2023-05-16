public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * length / 60; // miles
    }

    public override double GetPace()
    {
        return 60 / speed; // min per mile
    }
}