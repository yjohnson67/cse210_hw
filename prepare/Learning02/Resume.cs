class Resume 
{
    string name;
    List<Job> jobs = new List<Job>();

    public Resume(string name)
    {
        this.name = name;
    }

    public void AddJob(Job job)
    {
        jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine(name);
        
        foreach(Job job in jobs)
        {
            job.DisplayJobDetails();
        }
    }

}