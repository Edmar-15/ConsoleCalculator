using System;
using System.Threading;

namespace ConsoleCalculator.Classes
{
    public static class MiniGame
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("Mini_Game");
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine();

            int score = 0;

            while (true)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("1. Easy (One digit)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("2. Normal (Two digits)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("3. Hard (Three digits)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("4. Extreme (Four digits)");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("5. Exit");
                Console.WriteLine("====================================================");
                Console.WriteLine();

                Console.Write("Select difficulty (1-4): ");
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            PlayGame(1, 10, ref score);
                            break;
                        case 2:
                            PlayGame(10, 100, ref score);
                            break;
                        case 3:
                            PlayGame(100, 1000, ref score);
                            break;
                        case 4:
                            PlayGame(1000, 10000, ref score);
                            break;
                        case 5:
                            Console.Clear();
                            Console.Write("The game is closing. Please wait...");
                            Thread.Sleep(3000);
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        private static void PlayGame(int minRange, int maxRange, ref int score)
        {
            Random random = new Random();
            int lives = 3;

            while (lives > 0)
            {
                int num1 = random.Next(minRange, maxRange);
                int num2 = random.Next(minRange, maxRange);
                char[] operators = { '+', '-', '*' };
                char randomOperator = operators[random.Next(operators.Length)];

                Console.WriteLine("Loading...");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine(lives + " lives remaining.");
                Console.WriteLine();
                Console.WriteLine("Score: " + score);
                Console.WriteLine();
                Console.WriteLine("Game Start!");
                Console.WriteLine();
                Console.Write("Solve the problem: " + num1 + " " + randomOperator + " " + num2 + " = ");

                int userAnswer;

                if (int.TryParse(Console.ReadLine(), out userAnswer))
                {
                    int correctAnswer = CalculateAnswer(num1, num2, randomOperator);

                    if (userAnswer == correctAnswer)
                    {
                        Console.WriteLine("Correct! Well done.");
                        Console.WriteLine("//");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Correct! Well done.");
                        Console.WriteLine("//");
                        Console.WriteLine(" //");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Correct! Well done.");
                        Console.WriteLine("// //");
                        Console.WriteLine(" //");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Correct! Well done.");
                        Console.WriteLine("     //");
                        Console.WriteLine("// //");
                        Console.WriteLine(" //");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Correct! Well done.");
                        Console.WriteLine("       //");
                        Console.WriteLine("     //");
                        Console.WriteLine("// //");
                        Console.WriteLine(" //");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Correct! Well done.");
                        Console.WriteLine("          //");
                        Console.WriteLine("        //");
                        Console.WriteLine("      //");
                        Console.WriteLine("//  //");
                        Console.WriteLine(" //");
                        Thread.Sleep(1200);
                        Console.Clear();
                        score += 10;
                        Console.WriteLine("Loading Next Question...");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\\");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("\\");
                        Console.WriteLine("  \\");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("\\");
                        Console.WriteLine("  \\");
                        Console.WriteLine("    \\");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("\\");
                        Console.WriteLine("  \\");
                        Console.WriteLine("    \\");
                        Console.WriteLine("      \\");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("\\");
                        Console.WriteLine("  \\");
                        Console.WriteLine("    \\");
                        Console.WriteLine("      \\");
                        Console.WriteLine("        \\");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("\\");
                        Console.WriteLine("  \\");
                        Console.WriteLine("    \\");
                        Console.WriteLine("      \\");
                        Console.WriteLine("//      \\");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("\\");
                        Console.WriteLine("  \\  //");
                        Console.WriteLine("    \\");
                        Console.WriteLine("  //  \\");
                        Console.WriteLine("//      \\");
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("\\      //");
                        Console.WriteLine("  \\  //");
                        Console.WriteLine("    \\");
                        Console.WriteLine("  //  \\");
                        Console.WriteLine("//      \\");
                        Thread.Sleep(200);
                        Console.WriteLine();
                        Console.WriteLine("Incorrect. The correct answer is " + correctAnswer + ".");
                        lives--;
                        Console.WriteLine();
                        Console.WriteLine("You have " + lives + " lives remaining.");
                        Thread.Sleep(5000);
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine("Game over! You ran out of lives.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Going back to main menu in 3...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Game over! You ran out of lives.");
            Console.WriteLine();
            Console.WriteLine("Going back to main menu in 2...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Game over! You ran out of lives.");
            Console.WriteLine();
            Console.WriteLine("Going back to main menu in 1...");
            Thread.Sleep(1000);
            Console.Clear();
        }

        private static int CalculateAnswer(int num1, int num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }
    }
}