public class Job
{
    //VARIABLES
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //METHOD
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}