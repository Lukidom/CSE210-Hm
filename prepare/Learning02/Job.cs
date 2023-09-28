public class Job
{
    public string jobTitle;
    public string startYear;

    public string endYear;
    public string jobCompany;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{jobTitle} \n {jobCompany} \n {startYear} - {endYear}");
    }
}
