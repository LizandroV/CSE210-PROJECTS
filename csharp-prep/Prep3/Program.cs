using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();
        ////WHILE LOOPS
        //string response1 = "yes";
        //while (response1 == "yes")
        //{
        //    Console.Write("Do you want to continue? ");
        //    response1 = Console.ReadLine();
        //}

        ////DO WHILE LOOPS
        //string response2;
        //do
        //{
        //    Console.Write("Do you want to continue? ");
        //    response2 = Console.ReadLine();
        //} while (response2 == "yes");

        //// FOR LOOP
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(i);
        //}

        ////FOREACH LOOP
        //List<string> colors = new List<string>
        //{
        //    "Red",
        //    "Green",
        //    "Yellow",
        //    "Black",
        //    "White"
        //};
        //foreach (string color in colors)
        //{
        //    Console.WriteLine(color);
        //}

        ////RANDOM NUMBERS
        bool newGame = true;

        do{
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,101);
            //Console.WriteLine($"The random number is {number}");

            Console.WriteLine("GUESS THE NUMBER");
            Console.WriteLine();

            bool inGame = true;
            int count = 1;

            while (inGame == true){
                Console.Write("What is the magic number?  -->  ");
                string guessNumber = Console.ReadLine();
                int guess = Int32.Parse(guessNumber);

                if (guess == number){
                    Console.WriteLine($"You guessed it!, The magic number was {number}");
                    inGame = false;
                    Console.WriteLine($"It took you only {count} intents");
                }

                else if (guess > number){
                    Console.WriteLine("Lower");
                    count ++;
                }

                else if (guess < number){
                    Console.WriteLine("Higher");
                    count ++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            string response;
            Console.Write("Play again? ");
            response = Console.ReadLine();
            if (response == "yes"){
                newGame = true;
                Console.WriteLine("Here we go again");
            }
            else{
                newGame = false;
                Console.WriteLine("Thanks for playing, Chau");
            }

        } while (newGame == true);
    }
}