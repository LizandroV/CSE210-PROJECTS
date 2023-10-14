using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        f1.setTop(2);
        f1.setBottom(2);
        Console.WriteLine(f1.getTop());
        Console.WriteLine(f1.getBottom());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());


        Fraction f2 = new Fraction(3);
        Console.WriteLine(f2.getTop());
        f2.setBottom(4);
        Console.WriteLine(f2.getBottom());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(4,6);
        f3.setBottom(9);
        f3.setTop(9);
        Console.WriteLine(f3.getTop());
        Console.WriteLine(f3.getBottom());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}

