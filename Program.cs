using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamp Oil, Rope, Bombs, you want it. Its your my friend, as long as you have enough Rupees.\n");

            Dictionary<string, double> morshuInventory = new Dictionary<string, double>();
            List<string> itemNames = new List<string>();
            List<double> itemPrices = new List<double>();
            morshuInventory.Add("Lamp Oil", 5);
            morshuInventory.Add("Rope", 10);
            morshuInventory.Add("Bomb", 20);
            morshuInventory.Add("Magical Shield", 160);
            morshuInventory.Add("Small Key", 100);
            morshuInventory.Add("Blue Candle", 60);
            morshuInventory.Add("Arrows", 80);
            morshuInventory.Add("Food", 100);
            morshuInventory.Add("Recovery Heart", 10);
            morshuInventory.Add("Blue Ring", 250);

            string runProgram = "y";
            do
            {

                foreach (KeyValuePair<string, double> item in morshuInventory)
                {
                    Console.WriteLine($"{item.Key}  {item.Value}");
                }

                Console.WriteLine("");

                Console.WriteLine("What Item do you want to buy, Link?");
                string userInput = Console.ReadLine();
                if (!morshuInventory.ContainsKey(userInput))
                {
                    Console.WriteLine("Sorry Link, I don't sell that.");
                    continue;
                }
                else
                {
                    itemNames.Add(userInput);
                    itemPrices.Add(morshuInventory.GetValueOrDefault(userInput, 0));
                    Console.WriteLine($"added {userInput} for {morshuInventory.GetValueOrDefault(userInput, 0)} Rupees");
                }

                Console.WriteLine("");

                do
                {
                    Console.WriteLine("Any other item you would like to buy, Link? (y/n)");
                    runProgram = Console.ReadLine().ToLower();
                    if (runProgram.Equals("y"))
                    {
                        break;
                    }
                    else if (runProgram.Equals("n"))
                    {
                        break;
                    }
                        
                } while (true);

            } while (runProgram == "y");



            Console.WriteLine(string.Format("{0,15} {1,15}", "Item", "Price"));
            Console.WriteLine(string.Format("{0,15} {1,15}", "=======", "======="));
            for (int i = 0; i < itemNames.Count; i++)
            {
                Console.WriteLine(string.Format("{0,15} {1,15}", itemNames[i], itemPrices[i]));
            }
            Console.WriteLine("========================================");
            Console.WriteLine($"Link that averages out to {itemPrices.Average()} Rupees\n");

            Console.WriteLine("Will you pay Link? (y/AHH)");
            string morshuReject = Console.ReadLine();

            if (morshuReject.Equals("y"))
            {
                Console.WriteLine("");
                Console.WriteLine("Rupee Balance: 0 \n");
                Console.WriteLine("Sorry Link, I can't give credit. Come back when your little mmmmmm...richer.");
            }
            else
            {
                Console.WriteLine("*Link picks up his sword to attack Morshu* AHHHHHhhhHhHhhHhHHHHHh");
            }

            

        }
    }
}
