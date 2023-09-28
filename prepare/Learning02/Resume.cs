using System;
public class Resume
{
    public string ownerName;
    public List<Job> jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"name: {ownerName}");
        Console.WriteLine($"jobs:");

            foreach (Job job in jobs)
            {
                job.DisplayJobDetails();
            }
    }
}