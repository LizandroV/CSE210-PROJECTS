using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine();

        //JOBS
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2000;
        job1._endYear = 2020;

        //job1.Display();
        //Console.WriteLine("++++++++++++");

        Job job2 = new Job();
        job2._jobTitle = "System Administrator";
        job2._company = "Apple";
        job2._startYear = 1998;
        job2._endYear = 2023;

        //job2.Display();
        //Console.WriteLine("++++++++++++");

        //RESUME
        Resume myResume = new Resume();
        myResume._name = "Lizandro Vivanco";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine();
        myResume.Display();    
    }
}