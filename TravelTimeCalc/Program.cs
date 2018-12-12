using System;

namespace TravelTimeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Travel Time Calculator");
            Console.WriteLine();

            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter miles: ");
                if (double.TryParse(Console.ReadLine(), out double miles))
                {
                    Console.Write("Enter miles per hour: ");
                    if (double.TryParse(Console.ReadLine(), out double mph))
                    {
                        Console.WriteLine();
                        double hours = miles / mph;
                        int minutes = (int)(hours * 60);
                        int hoursInt = minutes / 60;
                        minutes = minutes % 60;

                        Console.WriteLine("Estimated Travel Time");
                        Console.Write("---------------------");
                        Console.Write($"\nHours:   {hoursInt}");
                        Console.WriteLine($"\nMinutes: {minutes}");
                    }
                }
                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
            }

        }
    }
}
