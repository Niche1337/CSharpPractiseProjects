using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{

    class FitnessFrog
    {
        static void Main()
        {
            var runningTotal = 0.0;
            while (true)
            {
                // Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                // Add minutes exercised to total 
                try
                {
                    var minutes = double.Parse(entry);
                    if (minutes <= 0)
                    {
                        Console.WriteLine($"{minutes} is not an acceptable value.");
                        continue;
                    }

                    checkMinutes(minutes);

                    runningTotal = runningTotal + minutes;

                    // Display total minutes exercised to the screen 
                    Console.WriteLine($"You've entered {runningTotal} minutes.");
                }
                catch (FormatException)
                {

                    Console.WriteLine("That is not a valid input");
                    continue;
                }

                // Repeat until user quits
            }

            Console.WriteLine("Goodbye");
        }

        private static void checkMinutes(double minutes)
        {
            if (minutes <= 10)
            {
                Console.WriteLine("Better than nothing, am I right?");
            }
            else if (minutes <= 30)
            {
                Console.WriteLine("Way to go hot stuff!");
            }
            else if (minutes <= 60)
            {
                Console.WriteLine("You must be a ninja warrior in training!");
            }
            else
            {
                Console.WriteLine("Okay, now you're just showing off!");
            }
        }
    }
}
