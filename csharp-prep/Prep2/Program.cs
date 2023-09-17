using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();
        Console.Write("What is your grade percentage?: ");
        int grade = int.Parse(Console.ReadLine());
        Console.WriteLine();

        string letter;

        if(grade >= 90)
        {
            letter = "A";
        }

        else if(grade >= 80)
        {
            letter = "B";
        }

        else if(grade >= 70)
        {
            letter = "C";
        }

        else if(grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}");
    }
}