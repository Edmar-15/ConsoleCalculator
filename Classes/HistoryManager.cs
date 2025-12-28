using System;
using System.Collections.Generic;

namespace ConsoleCalculator.Classes
{
    public static class HistoryManager
    {
        private static List<string> calculationHistory = new List<string>();

        public static void Add(string entry)
        {
            if (entry != null)
            {
                calculationHistory.Add(entry);
            }
        }

        public static void Print()
        {
            Console.Clear();
            Console.WriteLine("Calculation History:");
            Console.WriteLine();

            foreach (var entry in calculationHistory)
            {
                Console.WriteLine(entry);
                Console.WriteLine();
            }

            Console.Write("Press any key to return in main menu...");
            Console.ReadKey(true);
        }
    }
}