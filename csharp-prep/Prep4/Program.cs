using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();
        bool inGame = true;
        int largest = 0;

        List<int> numberList = new List<int>{};
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do {
            Console.Write("Enter Number: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number != 0){
                numberList.Add(number);
                if (number > largest){
                    largest = number;
                }
            }

            else{
                inGame = false;
            }

        } while (inGame == true);

        //SUM
        int sumList = 0;
        foreach (int i in numberList){
            sumList += i;
        }

        Console.WriteLine($"The sum is: {sumList}");

        //AVERAGE
        float average = ((float)sumList)/numberList.Count;
        Console.WriteLine($"The average is: {average}");

        //LARGEST
        Console.WriteLine($"The largest number is: {largest}");
    }
}