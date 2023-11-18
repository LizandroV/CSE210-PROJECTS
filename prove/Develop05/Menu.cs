using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eternal_Quest
{
    public class Menu
    {
        private List<string> menu = new List<string>()
        {
            "  1. Create New Goal",
            "  2. List Goals",
            "  3. Save Goals",
            "  4. Load Goals",
            "  5. Record Event",
            "  6. Quit"
        };

        public void DisplayMenu()
        {
            Console.WriteLine("Menu options");
            Console.WriteLine();

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Select a choise from the menu");
        }

        public void GoalTypes()
        {
            Console.Clear();
            Console.WriteLine("The types or Goals are\n");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal\n");
            Console.WriteLine("Which type of goal would you like to create?");
        }
    }
}