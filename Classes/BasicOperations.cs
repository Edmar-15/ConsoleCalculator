using ConsoleCalculator.Classes;
using System;

namespace ConsoleCalculator.Classes
{
    public static class BasicOperations
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Perform Basic Operations");
                Console.WriteLine();

                Console.WriteLine("Choose a calculation:");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("1. Addition");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("4. Division");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("5. Remainder");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("6. Return to the main calculation choices");
                Console.WriteLine();

                Console.Write("Enter your choice (1-6): ");
                string operationChoice = Console.ReadLine();

                switch (operationChoice)
                {
                    case "1":
                        PerformTwoNumberOperation("+", (a, b) => a + b);
                        break;
                    case "2":
                        PerformTwoNumberOperation("-", (a, b) => a - b);
                        break;
                    case "3":
                        PerformTwoNumberOperation("*", (a, b) => a * b);
                        break;
                    case "4":
                        PerformTwoNumberOperation("/", (a, b) => a / b);
                        break;
                    case "5":
                        PerformTwoNumberOperation("%", (a, b) => a % b);
                        break;
                    case "6":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void PerformTwoNumberOperation(string opSymbol, Func<double, double, double> op)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter the first number: ");
                double num1;
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    while (true)
                    {
                        Console.Write("Enter the second number: ");
                        double num2;
                        if (double.TryParse(Console.ReadLine(), out num2))
                        {
                            // For division, preserve original behavior (no explicit divide-by-zero check in original).
                            double result = op(num1, num2);
                            Console.WriteLine("{0} {1} {2} = {3}", num1, opSymbol, num2, result);
                            string historyEntry = string.Format("{0} {1} {2} = {3}", num1, opSymbol, num2, result);
                            HistoryManager.Add(historyEntry);
                            Console.WriteLine("Press any key to make another calculations...");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.ReadKey();
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ReadKey();
                }
            }
        }
    }
}