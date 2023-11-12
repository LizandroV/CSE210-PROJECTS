using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Yellow", 4);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Green", 3, 6);
        shapes.Add(s2);

        Circle s3 = new Circle("blue", 8);
        shapes.Add(s3);


        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            System.Console.WriteLine($"The Color {color} shape has an area of {area}.");
        }
    }
}