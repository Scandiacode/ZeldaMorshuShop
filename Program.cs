using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamp Oil, Rope, Bombs, you want it. Its your my friend, as long as you have enough Rupees.");

            while (true)
            {
                Console.WriteLine("What Item do you want to buy, Link?");
                string itemChoice = Console.ReadLine();
                /*
                if ()
                {
                    Console.WriteLine("Hey Link");
                }
                else
                {
                    Console.WriteLine("Sorry Link, I don't sell that.");
                    break;
                }
                */
            }

            
            Console.WriteLine("Sorry Link, I can't give credit. Come back when your little mmmmmm...richer.");

           
        }

        static void MenuDisplayTable(int itemChoice)
        {


            List<string> itemNames = new List<string> {

                    "Lamp Oil",
                    "Rope",
                    "Bomb",
                    "Magical Shield",
                    "Small Key",
                    "Blue Candle",
                    "Arrows",
                    "Food",
                    "Recovery Heart",
                    "Blue Ring"
                };

            List<int> itemPrices = new List<int> {

                    5,
                    10,
                    20,
                    160,
                    100,
                    60,
                    80,
                    100,
                    10,
                    250
                };

            Console.WriteLine(string.Format("{0,15} {1,15}", "Item", "Price"));
            Console.WriteLine(string.Format("{0,15} {1,15}", "=======", "======="));



        }
    }
}
