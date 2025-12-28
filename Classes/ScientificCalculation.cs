using ConsoleCalculator.Classes;
using System;

namespace ConsoleCalculator.Classes
{
    public static class ScientificCalculations
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Performing Scientific Calculations");
                Console.WriteLine();

                Console.WriteLine("Choose a calculation:");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("1. sin");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("2. cos");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("3. tan");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("4. π");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("5. Hypotenuse (hyp)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("6. Arcsin (sin^-1)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("7. Arccos (cos^-1)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("8. Arctan (tan^-1)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("9. Return to main calculation choices");
                Console.WriteLine();

                Console.Write("Enter your choice (1-9): ");
                string operationChoice = Console.ReadLine();

                switch (operationChoice)
                {
                    case "1":
                        ComputeTrig("sin", Math.Sin);
                        break;
                    case "2":
                        ComputeTrig("cos", Math.Cos);
                        break;
                    case "3":
                        ComputeTrig("tan", Math.Tan);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("π = {0}", Math.PI);
                        Console.WriteLine("Press any key to make another calculations...");
                        Console.ReadKey();
                        break;
                    case "5":
                        ComputeHypotenuse();
                        break;
                    case "6":
                        ComputeArc("Arcsin", Math.Asin);
                        break;
                    case "7":
                        ComputeArc("Arccos", Math.Acos);
                        break;
                    case "8":
                        ComputeArc("Arctan", Math.Atan);
                        break;
                    case "9":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ComputeTrig(string name, Func<double, double> func)
        {
            Console.Clear();
            Console.Write("Enter angle in degrees: ");
            double angleDegrees;
            if (double.TryParse(Console.ReadLine(), out angleDegrees))
            {
                double angleRadians = angleDegrees * (Math.PI / 180);
                double result = func(angleRadians);
                Console.WriteLine("{0}({1}°) = {2}", name, angleDegrees, result);
                string historyEntry = string.Format("{0}({1}°) = {2}", name, angleDegrees, result);
                HistoryManager.Add(historyEntry);
                Console.WriteLine("Press any key to make another calculations...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private static void ComputeHypotenuse()
        {
            Console.Clear();
            Console.Write("Enter side length A: ");
            double sideA;
            if (double.TryParse(Console.ReadLine(), out sideA))
            {
                Console.Write("Enter side length B: ");
                double sideB;
                if (double.TryParse(Console.ReadLine(), out sideB))
                {
                    double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
                    Console.WriteLine("Hypotenuse (hyp) = {0}", hypotenuse);
                    string historyEntry = string.Format("Hypotenuse (hyp) = {0}", hypotenuse);
                    HistoryManager.Add(historyEntry);
                    Console.WriteLine("Press any key to make another calculations...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private static void ComputeArc(string name, Func<double, double> func)
        {
            Console.Clear();
            Console.Write("Enter value for {0}: ", name);
            double value;
            if (double.TryParse(Console.ReadLine(), out value))
            {
                double resultDegrees = func(value) * (180 / Math.PI);
                Console.WriteLine("{0}({1}) = {2}°", name, value, resultDegrees);
                string historyEntry = string.Format("{0}({1}) = {2}°", name, value, resultDegrees);
                HistoryManager.Add(historyEntry);
                Console.WriteLine("Press any key to make another calculations...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}