using System;

class Program
{
    // Method (Behaviors)(Function)
    static void Main(string[] args)
    {
        // Create an instance of a class
        // (Instantiate a class)
        // (Create a class object)

        // (Class Type) (Object Name) = new (Constructor)
        Resume resume = new Resume("Allison Rose");
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);
        resume.AddJob(job1);
        resume.AddJob(job2);
        resume.Display();

    }
}