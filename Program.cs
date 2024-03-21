using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<DateTime, int> waterConsumption = new Dictionary<DateTime, int>();

        while (true)
        {
            Console.WriteLine("1. Record Water Consumption");
            Console.WriteLine("2. View Daily Water Consumption");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RecordWaterConsumption(waterConsumption);
                    break;
                case "2":
                    ViewDailyWaterConsumption(waterConsumption);
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void RecordWaterConsumption(Dictionary<DateTime, int> waterConsumption)
    {
        Console.Write("Enter the amount of water consumed (in milliliters): ");
        int amount = int.Parse(Console.ReadLine());

        DateTime today = DateTime.Today;

        if (waterConsumption.ContainsKey(today))
        {
            waterConsumption[today] += amount;
        }
        else
        {
            waterConsumption.Add(today, amount);
        }

        Console.WriteLine("Water consumption recorded successfully for today.");
    }

    static void ViewDailyWaterConsumption(Dictionary<DateTime, int> waterConsumption)
    {
        DateTime today = DateTime.Today;

        if (waterConsumption.ContainsKey(today))
        {
            Console.WriteLine($"Water consumed today: {waterConsumption[today]} milliliters");
        }
        else
        {
            Console.WriteLine("No water consumption recorded for today.");
        }
    }
}

