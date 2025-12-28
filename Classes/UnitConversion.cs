using ConsoleCalculator.Classes;
using System;

namespace ConsoleCalculator.Classes
{
    public static class UnitConversion
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Perform Unit Conversions");
                Console.WriteLine();
                Console.WriteLine("Choose from different units: ");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("1. Length");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("2. Area");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("3. Volume");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("4. Weight");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("5. Temperature");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("6. Speed");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("7. Pressure");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("8. Power");
                Console.WriteLine("====================================================");
                Console.WriteLine();
                Console.WriteLine("9. Return to main calculation choices");
                Console.WriteLine();

                Console.Write("Enter your choice (1-9): ");
                string operationChoice = Console.ReadLine();

                switch (operationChoice)
                {
                    case "1":
                        LengthConversions();
                        break;
                    case "2":
                        AreaConversions();
                        break;
                    case "3":
                        VolumeConversions();
                        break;
                    case "4":
                        WeightConversions();
                        break;
                    case "5":
                        TemperatureConversions();
                        break;
                    case "6":
                        SpeedConversions();
                        break;
                    case "7":
                        PressureConversions();
                        break;
                    case "8":
                        PowerConversions();
                        break;
                    case "9":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void LengthConversions()
        {
            Console.Clear();
            Console.WriteLine("Perform Length Unit Conversions");
            Console.WriteLine();
            Console.WriteLine("Metric Units: ");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1. Kilometer (km)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. Meter (m)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. Return to unit conversions");
            Console.WriteLine();

            Console.Write("Enter your choice (1-3): ");
            string choiceCase1 = Console.ReadLine();
            switch (choiceCase1)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in kilometers (km): ");
                        double kilometers;
                        if (double.TryParse(Console.ReadLine(), out kilometers))
                        {
                            Console.WriteLine(kilometers + " km = " + kilometers + " km");
                            Console.WriteLine(kilometers + " km = " + kilometers * 1000 + " m");
                            Console.WriteLine(kilometers + " km = " + kilometers * 10000 + " dm");
                            Console.WriteLine(kilometers + " km = " + kilometers * 100000 + " cm");
                            Console.WriteLine(kilometers + " km = " + kilometers * 1000000 + " mm");
                            Console.WriteLine(kilometers + " km = " + kilometers * 1000000000 + " µm");
                            Console.WriteLine(kilometers + " km = " + kilometers * 1000000000000 + " nm");
                            Console.WriteLine(kilometers + " km = " + kilometers * 1000000000000000 + " pm");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(kilometers + " km = " + Math.Round(kilometers * 39370.07874015748031, 7) + " inches");
                            Console.WriteLine(kilometers + " km = " + Math.Round(kilometers * 0.0621371192237333969, 7) + " miles");
                            Console.WriteLine(kilometers + " km = " + Math.Round(kilometers * 3280.83989501312336, 7) + " feet");
                            Console.WriteLine(kilometers + " km = " + Math.Round(kilometers * 1093.613298337707787, 7) + " yards");

                            HistoryManager.Add(kilometers + " km = " + kilometers + " km");
                            HistoryManager.Add(kilometers + " km = " + kilometers * 1000 + " m");
                            HistoryManager.Add(kilometers + " km = " + kilometers * 10000 + " dm");
                            HistoryManager.Add(kilometers + " km = " + kilometers * 100000 + " cm");
                            HistoryManager.Add(kilometers + " km = " + kilometers * 1000000 + " mm");
                            HistoryManager.Add(kilometers + " km = " + kilometers * 1000000000 + " µm");
                            HistoryManager.Add(kilometers + " km = " + kilometers * 1000000000000 + " nm");
                            HistoryManager.Add(kilometers + " km = " + kilometers * 1000000000000000 + " pm");
                            HistoryManager.Add(kilometers + " km = " + Math.Round(kilometers * 39370.07874015748031, 7) + " inches");
                            HistoryManager.Add(kilometers + " km = " + Math.Round(kilometers * 0.0621371192237333969, 7) + " miles");
                            HistoryManager.Add(kilometers + " km = " + Math.Round(kilometers * 3280.83989501312336, 7) + " feet");
                            HistoryManager.Add(kilometers + " km = " + Math.Round(kilometers * 1093.613298337707787, 7) + " yards");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;

                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in meters (m): ");
                        double meters;
                        if (double.TryParse(Console.ReadLine(), out meters))
                        {
                            Console.WriteLine(meters + " m = " + meters + " m");
                            Console.WriteLine(meters + " m = " + meters * 0.001 + " km");
                            Console.WriteLine(meters + " m = " + meters * 10 + " dm");
                            Console.WriteLine(meters + " m = " + meters * 100 + " cm");
                            Console.WriteLine(meters + " m = " + meters * 1000 + " mm");
                            Console.WriteLine(meters + " m = " + meters * 1000000 + " µm");
                            Console.WriteLine(meters + " m = " + meters * 1000000000 + " nm");
                            Console.WriteLine(meters + " m = " + meters * 1000000000000 + " pm");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(meters + " m = " + Math.Round(meters * 39.3700787, 7) + " inches");
                            Console.WriteLine(meters + " m = " + Math.Round(meters * 0.0006214, 7) + " miles");
                            Console.WriteLine(meters + " m = " + Math.Round(meters * 3.2808399, 7) + " feet");
                            Console.WriteLine(meters + " m = " + Math.Round(meters * 1.0936133, 7) + " yards");

                            HistoryManager.Add(meters + " m = " + meters + " m");
                            HistoryManager.Add(meters + " m = " + meters * 0.001 + " km");
                            HistoryManager.Add(meters + " m = " + meters * 10 + " dm");
                            HistoryManager.Add(meters + " m = " + meters * 100 + " cm");
                            HistoryManager.Add(meters + " m = " + meters * 1000 + " mm");
                            HistoryManager.Add(meters + " m = " + meters * 1000000 + " µm");
                            HistoryManager.Add(meters + " m = " + meters * 1000000000 + " nm");
                            HistoryManager.Add(meters + " m = " + meters * 1000000000000 + " pm");
                            HistoryManager.Add(meters + " m = " + Math.Round(meters * 39.3700787, 7) + " inches");
                            HistoryManager.Add(meters + " m = " + Math.Round(meters * 0.0006214, 7) + " miles");
                            HistoryManager.Add(meters + " m = " + Math.Round(meters * 3.2808399, 7) + " feet");
                            HistoryManager.Add(meters + " m = " + Math.Round(meters * 1.0936133, 7) + " yards");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;

                case "3":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        private static void AreaConversions()
        {
            Console.Clear();
            Console.WriteLine("Perform Area Conversions");
            Console.WriteLine();
            Console.WriteLine("Metric Units: ");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1. Square Kilometer (km2)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. Square Meter (m2)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. Return to unit conversions");
            Console.WriteLine();

            Console.Write("Enter your choice (1-3): ");
            string choiceCase2 = Console.ReadLine();

            switch (choiceCase2)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in square kilometers (km2): ");
                        double squareKilometers;
                        if (double.TryParse(Console.ReadLine(), out squareKilometers))
                        {
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1000000, 7) + " m2");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers, 7) + " km2");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 100000000, 7) + " dm2");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10000000000, 7) + " cm2");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1000000000000, 7) + " mm2");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 100, 7) + " ha");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10000, 7) + " a");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1550003100.006200012, 7) + " in2");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 0.386102158542445847, 7) + " mi2");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10763910.41670972231, 7) + " ft2");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1195990.046301080256, 7) + " yd2");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 247.1054072593638123, 7) + " ac");
                            Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 39536.86103474645476, 7) + " rd2");

                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1000000, 7) + " m2");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers, 7) + " km2");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 100000000, 7) + " dm2");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10000000000, 7) + " cm2");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1000000000000, 7) + " mm2");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 100, 7) + " ha");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10000, 7) + " a");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1550003100.006200012, 7) + " in2");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 0.386102158542445847, 7) + " mi2");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10763910.41670972231, 7) + " ft2");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1195990.046301080256, 7) + " yd2");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 247.1054072593638123, 7) + " ac");
                            HistoryManager.Add(squareKilometers + " km2 = " + Math.Round(squareKilometers * 39536.86103474645476, 7) + " rd2");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in meters (m): ");
                        double squareMeters;
                        if (double.TryParse(Console.ReadLine(), out squareMeters))
                        {
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters, 7) + " m2");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.000001, 7) + " km2");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 100, 7) + " dm2");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 10000, 7) + " cm2");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 1000000, 7) + " mm2");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0001, 7) + " ha");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.01, 7) + " a");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 1550.0031, 7) + " in2");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 3.861e-7, 7) + " mi2");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 10.7639104, 7) + " ft2");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 1.19599, 7) + " yd2");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0002471, 7) + " ac");
                            Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0395369, 7) + " rd2");

                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters, 7) + " m2");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 0.000001, 7) + " km2");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 100, 7) + " dm2");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 10000, 7) + " cm2");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 1000000, 7) + " mm2");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0001, 7) + " ha");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 0.01, 7) + " a");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 1550.0031, 7) + " in2");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 3.861e-7, 7) + " mi2");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 10.7639104, 7) + " ft2");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 1.19599, 7) + " yd2");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0002471, 7) + " ac");
                            HistoryManager.Add(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0395369, 7) + " rd2");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "3":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        private static void VolumeConversions()
        {
            Console.Clear();
            Console.WriteLine("Perform Volume Conversions");
            Console.WriteLine();
            Console.WriteLine("Metric Units: ");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1. Cubic meter (m3)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. Liter (l)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. Return to unit conversions");
            Console.WriteLine();

            Console.Write("Enter your choice (1-3): ");
            string choiceCase3 = Console.ReadLine();

            switch (choiceCase3)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in cubic meters (m3): ");
                        double cubicMeters;
                        if (double.TryParse(Console.ReadLine(), out cubicMeters))
                        {
                            Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters, 7) + " m3");
                            Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 10, 7) + " hl");
                            Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000, 7) + " dm3");
                            Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000, 7) + " cm3");
                            Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000000, 7) + " mm3");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000, 7) + " l");
                            Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 10000, 7) + " dl");
                            Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 100000, 7) + " cl");
                            Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000, 7) + " ml");

                            HistoryManager.Add(cubicMeters + " m3 = " + Math.Round(cubicMeters, 7) + " m3");
                            HistoryManager.Add(cubicMeters + " m3 = " + Math.Round(cubicMeters * 10, 7) + " hl");
                            HistoryManager.Add(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000, 7) + " dm3");
                            HistoryManager.Add(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000, 7) + " cm3");
                            HistoryManager.Add(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000000, 7) + " mm3");
                            HistoryManager.Add(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000, 7) + " l");
                            HistoryManager.Add(cubicMeters + " m3 = " + Math.Round(cubicMeters * 10000, 7) + " dl");
                            HistoryManager.Add(cubicMeters + " m3 = " + Math.Round(cubicMeters * 100000, 7) + " cl");
                            HistoryManager.Add(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000, 7) + " ml");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in liters (l): ");
                        double liters;
                        if (double.TryParse(Console.ReadLine(), out liters))
                        {
                            Console.WriteLine(liters + " l = " + Math.Round(liters * 0.001, 7) + " m3");
                            Console.WriteLine(liters + " l = " + Math.Round(liters * 0.01, 7) + " hl");
                            Console.WriteLine(liters + " l = " + Math.Round(liters * 1, 7) + " dm3");
                            Console.WriteLine(liters + " l = " + Math.Round(liters * 1000, 7) + " cm3");
                            Console.WriteLine(liters + " l = " + Math.Round(liters * 1000000, 7) + " mm3");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(liters + " l = " + Math.Round(liters * 1, 7) + " l");
                            Console.WriteLine(liters + " l = " + Math.Round(liters * 10, 7) + " dl");
                            Console.WriteLine(liters + " l = " + Math.Round(liters * 100, 7) + " cl");
                            Console.WriteLine(liters + " l = " + Math.Round(liters * 1000, 7) + " ml");

                            HistoryManager.Add(liters + " l = " + Math.Round(liters * 0.001, 7) + " m3");
                            HistoryManager.Add(liters + " l = " + Math.Round(liters * 0.01, 7) + " hl");
                            HistoryManager.Add(liters + " l = " + Math.Round(liters * 1, 7) + " dm3");
                            HistoryManager.Add(liters + " l = " + Math.Round(liters * 1000, 7) + " cm3");
                            HistoryManager.Add(liters + " l = " + Math.Round(liters * 1000000, 7) + " mm3");
                            HistoryManager.Add(liters + " l = " + Math.Round(liters * 1, 7) + " l");
                            HistoryManager.Add(liters + " l = " + Math.Round(liters * 10, 7) + " dl");
                            HistoryManager.Add(liters + " l = " + Math.Round(liters * 100, 7) + " cl");
                            HistoryManager.Add(liters + " l = " + Math.Round(liters * 1000, 7) + " ml");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "3":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        private static void WeightConversions()
        {
            Console.Clear();
            Console.WriteLine("Perform Weight Conversion");
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1. Kilogram (kg)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. Pound (lb)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. Return to unit conversions");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Enter your choice (1-3): ");
            string choiceCase4 = Console.ReadLine();
            switch (choiceCase4)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in kilograms (kg): ");
                        double kilograms;
                        if (double.TryParse(Console.ReadLine(), out kilograms))
                        {
                            Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms, 7) + " kg");
                            Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 1000, 7) + " g");
                            Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 1000000, 7) + " mg");
                            Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 0.001, 7) + " t");
                            Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 5000, 7) + " ct");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 2.2046226, 7) + " lb");
                            Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 35.2739619, 7) + " oz");
                            Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 15432.3583529, 7) + " gr");

                            HistoryManager.Add(kilograms + " kg = " + Math.Round(kilograms, 7) + " kg");
                            HistoryManager.Add(kilograms + " kg = " + Math.Round(kilograms * 1000, 7) + " g");
                            HistoryManager.Add(kilograms + " kg = " + Math.Round(kilograms * 1000000, 7) + " mg");
                            HistoryManager.Add(kilograms + " kg = " + Math.Round(kilograms * 0.001, 7) + " t");
                            HistoryManager.Add(kilograms + " kg = " + Math.Round(kilograms * 5000, 7) + " ct");
                            HistoryManager.Add(kilograms + " kg = " + Math.Round(kilograms * 2.2046226, 7) + " lb");
                            HistoryManager.Add(kilograms + " kg = " + Math.Round(kilograms * 35.2739619, 7) + " oz");
                            HistoryManager.Add(kilograms + " kg = " + Math.Round(kilograms * 15432.3583529, 7) + " gr");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in pounds (lb): ");
                        double pounds;
                        if (double.TryParse(Console.ReadLine(), out pounds))
                        {
                            Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 0.453592374495299, 7) + " kg");
                            Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 453.592374495299, 7) + " g");
                            Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 453529.374495299, 7) + " mg");
                            Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 0.000453592374495299, 7) + " t");
                            Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 2267.961872476495, 7) + " ct");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 1, 7) + " lb");
                            Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 16.0000001360777086551081, 7) + " oz");
                            Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 7000.0000693542724444330171, 7) + " gr");

                            HistoryManager.Add(pounds + " lb = " + Math.Round(pounds * 0.453592374495299, 7) + " kg");
                            HistoryManager.Add(pounds + " lb = " + Math.Round(pounds * 453.592374495299, 7) + " g");
                            HistoryManager.Add(pounds + " lb = " + Math.Round(pounds * 453529.374495299, 7) + " mg");
                            HistoryManager.Add(pounds + " lb = " + Math.Round(pounds * 0.000453592374495299, 7) + " t");
                            HistoryManager.Add(pounds + " lb = " + Math.Round(pounds * 2267.961872476495, 7) + " ct");
                            HistoryManager.Add(pounds + " lb = " + Math.Round(pounds * 1, 7) + " lb");
                            HistoryManager.Add(pounds + " lb = " + Math.Round(pounds * 16.0000001360777086551081, 7) + " oz");
                            HistoryManager.Add(pounds + " lb = " + Math.Round(pounds * 7000.0000693542724444330171, 7) + " gr");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "3":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        private static void TemperatureConversions()
        {
            Console.Clear();
            Console.WriteLine("Perform Temperature Conversion");
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1. Degree Celsius (°C)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. Degrees Fahrenheit (°F)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. Kelvin (K)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("4. Return to unit conversions");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Enter your choice (1-4): ");
            string choiceCase5 = Console.ReadLine();
            switch (choiceCase5)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in degree celsius (°C): ");
                        double celsius;
                        if (double.TryParse(Console.ReadLine(), out celsius))
                        {
                            Console.WriteLine(celsius + " °C = " + celsius + "°C");
                            Console.WriteLine(celsius + " °C = " + ((1.8 * celsius) + 32) + "°F");
                            Console.WriteLine(celsius + " °C = " + (celsius + 273.15) + " K");

                            HistoryManager.Add(celsius + " °C = " + celsius + "°C");
                            HistoryManager.Add(celsius + " °C = " + ((1.8 * celsius) + 32) + "°F");
                            HistoryManager.Add(celsius + " °C = " + (celsius + 273.15) + " K");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in degree fahrenheit (°F): ");
                        double fahrenheit;
                        if (double.TryParse(Console.ReadLine(), out fahrenheit))
                        {
                            Console.WriteLine(fahrenheit + " °F = " + fahrenheit + "°F");
                            Console.WriteLine(fahrenheit + " °F = " + ((fahrenheit - 32) / 1.8) + "°C");
                            Console.WriteLine(fahrenheit + " °F = " + (((fahrenheit - 32) / 1.8) + 273.15) + " K");

                            HistoryManager.Add(fahrenheit + " °F = " + fahrenheit + "°F");
                            HistoryManager.Add(fahrenheit + " °F = " + ((fahrenheit - 32) / 1.8) + "°C");
                            HistoryManager.Add(fahrenheit + " °F = " + (((fahrenheit - 32) / 1.8) + 273.15) + " K");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "3":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in kelvin (K): ");
                        double kelvin;
                        if (double.TryParse(Console.ReadLine(), out kelvin))
                        {
                            Console.WriteLine(kelvin + " K = " + kelvin + " K");
                            Console.WriteLine(kelvin + " K = " + (kelvin - 273.15) + "°C");
                            Console.WriteLine(kelvin + " K = " + (((kelvin - 273.15) * 1.8) + 32) + "°F");

                            HistoryManager.Add(kelvin + " K = " + kelvin + " K");
                            HistoryManager.Add(kelvin + " K = " + (kelvin - 273.15) + "°C");
                            HistoryManager.Add(kelvin + " K = " + (((kelvin - 273.15) * 1.8) + 32) + "°F");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "4":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        private static void SpeedConversions()
        {
            Console.Clear();
            Console.WriteLine("Perform Speed Conversion");
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1. Meter/second (m/s)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. Kilometer/hour (km/h)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. Mile/hour (mph)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("4. Mach (Ma)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("5. Return to unit conversions");

            Console.WriteLine();
            Console.Write("Enter your choice (1-5): ");
            string choiceCase6 = Console.ReadLine();
            switch (choiceCase6)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in meter/second (m/s): ");
                        double meterPerSecond;
                        if (double.TryParse(Console.ReadLine(), out meterPerSecond))
                        {
                            Console.WriteLine(meterPerSecond + " m/s = " + meterPerSecond + "m/s");
                            Console.WriteLine(meterPerSecond + " m/s = " + (meterPerSecond * 3.6) + "km/h");
                            Console.WriteLine(meterPerSecond + " m/s = " + (meterPerSecond * 2.236936) + " mph");
                            Console.WriteLine(meterPerSecond + " m/s = " + (meterPerSecond * 0.0029386) + "Ma");

                            HistoryManager.Add(meterPerSecond + " m/s = " + meterPerSecond + "m/s");
                            HistoryManager.Add(meterPerSecond + " m/s = " + (meterPerSecond * 3.6) + "km/h");
                            HistoryManager.Add(meterPerSecond + " m/s = " + (meterPerSecond * 2.236936) + " mph");
                            HistoryManager.Add(meterPerSecond + " m/s = " + (meterPerSecond * 0.0029386) + "Ma");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in kilometer/hour (km/h): ");
                        double kilometerPerHour;
                        if (double.TryParse(Console.ReadLine(), out kilometerPerHour))
                        {
                            Console.WriteLine(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.277777777777778) + "m/s");
                            Console.WriteLine(kilometerPerHour + " km/h = " + kilometerPerHour + "km/h");
                            Console.WriteLine(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.621371111111111608208) + " mph");
                            Console.WriteLine(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.0008162777777777784308) + "Ma");

                            HistoryManager.Add(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.277777777777778) + "m/s");
                            HistoryManager.Add(kilometerPerHour + " km/h = " + kilometerPerHour + "km/h");
                            HistoryManager.Add(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.621371111111111608208) + " mph");
                            HistoryManager.Add(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.0008162777777777784308) + "Ma");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "3":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in mile/hour (mph): ");
                        double milePerHour;
                        if (double.TryParse(Console.ReadLine(), out milePerHour))
                        {
                            Console.WriteLine(milePerHour + " mph = " + (milePerHour * 0.44704005836555) + "m/s");
                            Console.WriteLine(milePerHour + " mph = " + (milePerHour * 1.60934421011598) + "km/h");
                            Console.WriteLine(milePerHour + " mph = " + milePerHour + " mph");
                            Console.WriteLine(milePerHour + " mph = " + (milePerHour * 0.00131367191551300523) + "Ma");

                            HistoryManager.Add(milePerHour + " mph = " + (milePerHour * 0.44704005836555) + "m/s");
                            HistoryManager.Add(milePerHour + " mph = " + (milePerHour * 1.60934421011598) + "km/h");
                            HistoryManager.Add(milePerHour + " mph = " + milePerHour + " mph");
                            HistoryManager.Add(milePerHour + " mph = " + (milePerHour * 0.00131367191551300523) + "Ma");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "4":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in Mach (Ma): ");
                        double mach;
                        if (double.TryParse(Console.ReadLine(), out mach))
                        {
                            Console.WriteLine(mach + " Ma = " + (mach * 340.2981101136595658) + "m/s");
                            Console.WriteLine(mach + " Ma = " + (mach * 1225.0731640917443688) + "km/h");
                            Console.WriteLine(mach + " Ma = " + (mach * 761.225073164091744823888) + " mph");
                            Console.WriteLine(mach + " Ma = " + mach + "Ma");

                            HistoryManager.Add(mach + " Ma = " + (mach * 340.2981101136595658) + "m/s");
                            HistoryManager.Add(mach + " Ma = " + (mach * 1225.0731640917443688) + "km/h");
                            HistoryManager.Add(mach + " Ma = " + (mach * 761.225073164091744823888) + " mph");
                            HistoryManager.Add(mach + " Ma = " + mach + "Ma");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "5":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        private static void PressureConversions()
        {
            Console.Clear();
            Console.WriteLine("Perform Pressure Conversion");
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1. Standard atmosphere (atm)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. Hectopascal (hPa)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. Kilopascal (kPa)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("4. Pounds/square inch (psi)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("5. Return to unit conversions");

            Console.WriteLine();
            Console.Write("Enter your choice (1-5): ");
            string choiceCase7 = Console.ReadLine();
            switch (choiceCase7)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in standard atmosphere (atm): ");
                        double atm;
                        if (double.TryParse(Console.ReadLine(), out atm))
                        {
                            Console.WriteLine(atm + " atm = " + atm + " atm");
                            Console.WriteLine(atm + " atm = " + (atm * 1013.250273830886503) + " hPa");
                            Console.WriteLine(atm + " atm = " + (atm * 101.3250273830886503) + " kPa");
                            Console.WriteLine(atm + " atm = " + (atm * 14.695952977081292059162322) + " psi");

                            HistoryManager.Add(atm + " atm = " + atm + " atm");
                            HistoryManager.Add(atm + " atm = " + (atm * 1013.250273830886503) + " hPa");
                            HistoryManager.Add(atm + " atm = " + (atm * 101.3250273830886503) + " kPa");
                            HistoryManager.Add(atm + " atm = " + (atm * 14.695952977081292059162322) + " psi");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in hectopascal (hPa): ");
                        double hPa;
                        if (double.TryParse(Console.ReadLine(), out hPa))
                        {
                            Console.WriteLine(hPa + " hPa = " + (hPa * 0.000986923) + " atm");
                            Console.WriteLine(hPa + " hPa = " + hPa + " hPa");
                            Console.WriteLine(hPa + " hPa = " + (hPa * 0.01) + " kPa");
                            Console.WriteLine(hPa + " hPa = " + (hPa * 0.014503774) + " psi");

                            HistoryManager.Add(hPa + " hPa = " + (hPa * 0.000986923) + " atm");
                            HistoryManager.Add(hPa + " hPa = " + hPa + " hPa");
                            HistoryManager.Add(hPa + " hPa = " + (hPa * 0.01) + " kPa");
                            HistoryManager.Add(hPa + " hPa = " + (hPa * 0.014503774) + " psi");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "3":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in kilopascal (kPa): ");
                        double kPa;
                        if (double.TryParse(Console.ReadLine(), out kPa))
                        {
                            Console.WriteLine(kPa + " hPa = " + (kPa * 0.00986923) + " atm");
                            Console.WriteLine(kPa + " hPa = " + (kPa * 10) + " hPa");
                            Console.WriteLine(kPa + " hPa = " + kPa + " kPa");
                            Console.WriteLine(kPa + " hPa = " + (kPa * 0.14503774) + " psi");

                            HistoryManager.Add(kPa + " hPa = " + (kPa * 0.00986923) + " atm");
                            HistoryManager.Add(kPa + " hPa = " + (kPa * 10) + " hPa");
                            HistoryManager.Add(kPa + " hPa = " + kPa + " kPa");
                            HistoryManager.Add(kPa + " hPa = " + (kPa * 0.14503774) + " psi");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "4":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in pounds/square inch (psi): ");
                        double psi;
                        if (double.TryParse(Console.ReadLine(), out psi))
                        {
                            Console.WriteLine(psi + " hPa = " + (psi * 0.068045944455560325500939) + " atm");
                            Console.WriteLine(psi + " hPa = " + (psi * 68.947571852677793) + " hPa");
                            Console.WriteLine(psi + " hPa = " + (psi * 6.8947571852677793) + " kPa");
                            Console.WriteLine(psi + " hPa = " + psi + " psi");

                            HistoryManager.Add(psi + " hPa = " + (psi * 0.068045944455560325500939) + " atm");
                            HistoryManager.Add(psi + " hPa = " + (psi * 68.947571852677793) + " hPa");
                            HistoryManager.Add(psi + " hPa = " + (psi * 6.8947571852677793) + " kPa");
                            HistoryManager.Add(psi + " hPa = " + psi + " psi");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "5":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        private static void PowerConversions()
        {
            Console.Clear();
            Console.WriteLine("Perform Power Conversion");
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1.Watt (W)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. Kilowatt (kW)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. Imperial Horsepower (hp)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("4. Metric Horsepower (PS)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("5. Return to unit conversions");

            Console.WriteLine();
            Console.Write("Enter your choice (1-5): ");
            string choiceCase8 = Console.ReadLine();
            switch (choiceCase8)
            {
                case "1":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in watt (W): ");
                        double watt;
                        if (double.TryParse(Console.ReadLine(), out watt))
                        {
                            Console.WriteLine(watt + " W = " + watt + " W");
                            Console.WriteLine(watt + " W = " + (watt * 0.001) + " kW");
                            Console.WriteLine(watt + " W = " + (watt * 0.0013410221) + " hp");
                            Console.WriteLine(watt + " W = " + (watt * 0.0013596216) + " PS");

                            HistoryManager.Add(watt + " W = " + watt + " W");
                            HistoryManager.Add(watt + " W = " + (watt * 0.001) + " kW");
                            HistoryManager.Add(watt + " W = " + (watt * 0.0013410221) + " hp");
                            HistoryManager.Add(watt + " W = " + (watt * 0.0013596216) + " PS");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in kilowatt (kW): ");
                        double kilowatt;
                        if (double.TryParse(Console.ReadLine(), out kilowatt))
                        {
                            Console.WriteLine(kilowatt + " kW = " + (kilowatt * 1000) + " W");
                            Console.WriteLine(kilowatt + " kW = " + kilowatt + " kW");
                            Console.WriteLine(kilowatt + " kW = " + (kilowatt * 1.3410221) + " hp");
                            Console.WriteLine(kilowatt + " kW = " + (kilowatt * 1.3596216) + " PS");

                            HistoryManager.Add(kilowatt + " kW = " + (kilowatt * 1000) + " W");
                            HistoryManager.Add(kilowatt + " kW = " + kilowatt + " kW");
                            HistoryManager.Add(kilowatt + " kW = " + (kilowatt * 1.3410221) + " hp");
                            HistoryManager.Add(kilowatt + " kW = " + (kilowatt * 1.3596216) + " PS");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "3":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in imperial horsepower (hp): ");
                        double iHorsepower;
                        if (double.TryParse(Console.ReadLine(), out iHorsepower))
                        {
                            Console.WriteLine(iHorsepower + " hp = " + (iHorsepower * 745.699865796395153) + " W");
                            Console.WriteLine(iHorsepower + " hp = " + (iHorsepower * 0.745699865796395153) + " kW");
                            Console.WriteLine(iHorsepower + " hp = " + iHorsepower + " hp");
                            Console.WriteLine(iHorsepower + " hp = " + (iHorsepower * 1.0138696446538800521541048) + " PS");

                            HistoryManager.Add(iHorsepower + " hp = " + (iHorsepower * 745.699865796395153) + " W");
                            HistoryManager.Add(iHorsepower + " hp = " + (iHorsepower * 0.745699865796395153) + " kW");
                            HistoryManager.Add(iHorsepower + " hp = " + iHorsepower + " hp");
                            HistoryManager.Add(iHorsepower + " hp = " + (iHorsepower * 1.0138696446538800521541048) + " PS");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "4":
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter the number in metric horsepower (PS): ");
                        double mHorsepower;
                        if (double.TryParse(Console.ReadLine(), out mHorsepower))
                        {
                            Console.WriteLine(mHorsepower + " PS = " + (mHorsepower * 735.49875936069271) + " W");
                            Console.WriteLine(mHorsepower + " PS = " + (mHorsepower * 0.73549875936069271) + " kW");
                            Console.WriteLine(mHorsepower + " PS = " + (mHorsepower * 0.986320090825270795418891) + " hp");
                            Console.WriteLine(mHorsepower + " PS = " + mHorsepower + " PS");

                            HistoryManager.Add(mHorsepower + " PS = " + (mHorsepower * 735.49875936069271) + " W");
                            HistoryManager.Add(mHorsepower + " PS = " + (mHorsepower * 0.73549875936069271) + " kW");
                            HistoryManager.Add(mHorsepower + " PS = " + (mHorsepower * 0.986320090825270795418891) + " hp");
                            HistoryManager.Add(mHorsepower + " PS = " + mHorsepower + " PS");

                            Console.WriteLine("Press any key to make another conversions...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        break;
                    }
                    break;
                case "5":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}