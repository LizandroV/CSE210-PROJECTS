using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        WritingAssignment  A1 = new WritingAssignment ("Lizandro Vivanco", "European History", "The Causes of World War II");
        System.Console.WriteLine(A1.GetSummary());
        System.Console.WriteLine(A1.GetWritingInformation());

    }
}