using Eternal_Quest;
using System.Runtime.InteropServices;

bool quit = false;
int myPoints = 0;
Menu menu = new Menu();

do
{
    Thread.Sleep(2000);
    Console.Clear();
    Console.WriteLine($"You have {myPoints} points");
    menu.DisplayMenu();
    Console.Write("> ");
    int choose = Convert.ToInt32(Console.ReadLine());

    if (choose == 1)
    {
        menu.GoalTypes();
        Console.Write("> ");
        int typechoose = Convert.ToInt32(Console.ReadLine());

        if (typechoose == 1)
        {
            Console.Clear();
            Console.WriteLine("--Simple Goal--\n");
            Console.WriteLine("What is the name of your goal?");
            Console.Write(">");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is a short description of it?");
            Console.Write(">");
            string description = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is the amount of points associated with this goal");
            Console.Write(">");
            int points = Convert.ToInt32(Console.ReadLine());
            
            SimpleGoal simple = new SimpleGoal(name , description, points);
        }
        else if (typechoose == 2)
        {
            Console.Clear();
            Console.WriteLine("--Eternal Goal--\n");
            Console.WriteLine("What is the name of your goal?");
            Console.Write(">");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is a short description of it?");
            Console.Write(">");
            string description = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is the amount of points associated with this goal");
            Console.Write(">");
            int points = Convert.ToInt32(Console.ReadLine());

            EternalGoal eternal = new EternalGoal(name, description, points);
        }
        else if (typechoose == 3)
        {
            Console.Clear();
            Console.WriteLine("--Checklist Goal--\n");
            Console.WriteLine("What is the name of your goal?");
            Console.Write(">");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is a short description of it?");
            Console.Write(">");
            string description = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is the amount of points associated with this goal");
            Console.Write(">");
            int points = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            Console.Write(">");
            int times = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            Console.Write(">");
            int bonus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, times, bonus);
        }
    }
    else if (choose == 2)
    {
        Console.WriteLine("2");
    }
    else if (choose == 3)
    {
        Console.WriteLine("3");
    }
    else if (choose == 4)
    {
        Console.WriteLine("4");
    }
    else if (choose == 5)
    {
        Console.WriteLine("5");
    }
    else if (choose == 6)
    {
        Console.WriteLine("Quit");
        quit = true;
    }
    else
    {
        Console.WriteLine($"{choose} - It is not an option");
    }
} while (quit == false);
