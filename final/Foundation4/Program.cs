public class Program
{
    public static void Main()
    {
        // Create a new list to store activities
        List<Activity> activities = new List<Activity>();

        // Add instances of Running, Cycling and Swimming activites to the list
        // Each activity has a specific date, duration, and additional properties specific to the activity type
        
        // Running activity on November 3, 2002, with a duration of 30 minutes and a distance of 3.0 miles
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));

        // Running activity on November 3, 2022, with a duration of 30 minutes and a distance of 4.8 miles
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));

        // Cycling activity on November 3, 2022, with a duration of 30 minutes and a distance of 10.0 miles
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 10.0));

        // Swimming activity on November 3, 2022, with a duration of 30 minutes and a pool length of 10 meters
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 10));

        // Iterate through the list of activities and print their summary using the GetSummary() method
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}