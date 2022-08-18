using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            float currentBalance = float.Parse(Console.ReadLine());
            string readingLine = Console.ReadLine();
            float price = 0;
            double sum = 0;
            while (readingLine != "Game Time")
            {
                string game = readingLine;


                if (game == "OutFall 4")
                {
                    price = 39.99f;
                }
                else if (game == "CS: OG")
                {
                    price = 15.99f;
                }
                else if (game == "Zplinter Zell")
                {
                    price = 19.99f;
                }
                else if (game == "Honored 2")
                {
                    price = 59.99f;
                }
                else if (game == "RoverWatch")
                {
                    price = 29.99f;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    price = 39.99f;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    price = 0f;
                }

                if (price <= currentBalance && price != 0)
                {
                    Console.WriteLine($"Bought {game}");
                    sum += price;
                    currentBalance = currentBalance - price;
                }
                else if (price > currentBalance && price != 0)
                {
                    Console.WriteLine("Too Expensive");
                }
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                readingLine = Console.ReadLine();
            }
            if(readingLine == "Game Time")
           {
                Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${currentBalance:f2}");
          }

        }
    }
}
