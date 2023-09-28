using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.jobCompany = "Dell";
        job1.jobTitle = "Software Engineer";
        job1.startYear = "2001";
        job1.endYear = "2019";
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2.jobCompany = "Macrosoft";
        job2.jobTitle = "Wharehouse man";
        job2.startYear = "2005";
        job2.endYear = "2006";
        // job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1.ownerName = "Luke Ramirez";
        resume1.jobs.Add(job1);
        resume1.jobs.Add(job2);

        resume1.Display();

    }
}