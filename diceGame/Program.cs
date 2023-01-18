using System;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] counts = new int[11];
            int rolls = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.WriteLine("How many dice do you want to throw?");
            rolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each * represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls);

            for (int i = 0; i < rolls; i++)
            {
                int roll1 = r.Next(6);

                int roll2 = r.Next(6);

                int total = roll1 + roll2;

                counts[total]++; 
            
            }

            for (int i = 0; i < 11; i++)
            {
                int number = i + 2;
                double percentage = counts[i] / (double)rolls * 100;
                int numberOfAsteriks = (int)percentage;
                string asteriks = "";

                for (int num = 0; num < numberOfAsteriks; num++)
                {
                    asteriks += "*";
                }

                Console.WriteLine(number.ToString() + ':' + asteriks.ToString());
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
