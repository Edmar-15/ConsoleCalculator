using ConsoleCalculator.Classes;
using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.WriteLine("===================================================");
            Console.WriteLine();
            Console.WriteLine("     Welcome to Calculator by Edmar A. Suayan      ");
            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press any key to enter...");
            Console.ReadKey(true);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose from different calculations: ");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("1. Basic Operations (+, -, *, /, %)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("2. Scientific Calculations (sin, cos, tan)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("3. Unit Conversion (m to km)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("4. View Calculation History");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("5. Play Minigame");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("6. Exit");

                Console.WriteLine();
                Console.Write("Enter your choice (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BasicOperations.Run();
                        break;

                    case "2":
                        ScientificCalculations.Run();
                        break;

                    case "3":
                        UnitConversion.Run();
                        break;

                    case "4":
                        HistoryManager.Print();
                        break;

                    case "5":
                        MiniGame.Run();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Calculator program closed.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Thankyou for staying...");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please enter a number between 1 to 6.");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}