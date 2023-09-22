using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> colors = new List<string>
        {
            "Red",
            "Green",
            "Yellow",
            "Black",
            "White"
        };

        foreach (string color in colors){
            Console.WriteLine(color);
        }
        Console.WriteLine(colors.Count);
        colors.Add("skyblue");
        colors.Add("Brown");

        foreach (string color in colors){
            Console.WriteLine(color);
        }
        Console.WriteLine(colors.Count);

        for (int i = 0; i < colors.Count; i++){
            Console.WriteLine(colors[i]);
        }

        static void DisplayMessage(string name){
            Console.WriteLine($"Hi {name}");
            Console.WriteLine("How are you?");
        
        }
        
        DisplayMessage("Lizandro");
        DisplayMessage("Rosa");

        static int AddNumbers(int first, int second){
            int sum = first + second;
            return sum;
        }

        Console.WriteLine(AddNumbers(8,9));
        Console.WriteLine(AddNumbers(8,10));
        Console.WriteLine(AddNumbers(8,11));

    }
}
