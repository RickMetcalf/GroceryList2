﻿using System;
using System.Collections.Generic;

namespace GroceryList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your grocery list");
            bool cont = true;
            List<grocery> groceries = new List<grocery>();
            while (cont)
            {
                Console.WriteLine("What Would you like to do?\n\n1)Add an item\n2)Remove an item\n3)Change an item\n4)View your list\n5)Exit");
                
                int menuChoice = 0;
                
                
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out menuChoice))
                    {
                        Console.WriteLine("Incorrect entry, please try again");
                    }
                    else
                    {
                        if (menuChoice >= 1 && menuChoice <= 5)
                        {
                            break;
                        }
                        Console.WriteLine("Incorrect entry, please try again");
                    }
                }
                

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("How many items d you want to add?");
                        int totalItems = int.Parse(Console.ReadLine());
                        for (int i = 0; i < totalItems; i++)
                        {
                            Console.WriteLine("What item are you adding?");
                            string name = Console.ReadLine();
                            Console.WriteLine("How many are you buying?");
                            int quanity = int.Parse(Console.ReadLine());
                            Console.WriteLine("What is the price of this item");
                            double price = double.Parse(Console.ReadLine());
                            double total = quanity * price;
                            groceries.Add(new grocery(name, quanity, price, total));
                        }
                        
                        break;

                    case 2:
                        //Add removal
                        break;
                    case 3:
                        //Add Change
                        break;
                    case 4:
                        Console.WriteLine("Here is your current list: ");
                        foreach (var g in groceries)
                        {
                            Console.WriteLine($"{g.FoodName} \t {g.FoodQuanity} \t {g.PricePerItem} \t ${g.TotalPrice}");
                        }
                        break;
                    case 5:
                        cont = false;
                        break;
                    default:
                        break;


                }
                
            }

            Console.Read();


            


        }
    }
}
