using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.Write("There will not be a newline after this.");
        Console.WriteLine(".......");
        int x;
        x = 5;
        Console.WriteLine(x);
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        if (x == 5){
            Console.WriteLine("HIII");
        }
        Console.WriteLine($"My number is {x}");
    }
}
