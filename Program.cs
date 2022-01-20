using System;
using System.Collections.Generic;
using System.IO;

namespace GroceryList2
{
    internal class Program
    {
        private const string FILE_PATH = @"C:\Users\rmetc\Desktop\GroceryList.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your grocery list");
            bool cont = true;
            List<Grocery> groceries = new List<Grocery>();
            while (cont)
            {
                Console.WriteLine("What Would you like to do?\n\n1)Add an item\n2)Remove an item\n3)Change an item\n4)View your list\n5)Print your list to a text file\n6)Exit");
                
                int menuChoice = 0;
                
                
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out menuChoice))
                    {
                        Console.WriteLine("Incorrect entry, please try again");
                    }
                    else
                    {
                        if (menuChoice >= 1 && menuChoice <= 6)
                        {
                            break;
                        }
                        Console.WriteLine("Incorrect entry, please try again");
                    }
                }
                

                switch (menuChoice)
                {
                    case 1:
                        AddGroceries(groceries);

                        break;

                    case 2:
                        //Add Removal
                        break;
                    case 3:
                        //Add Change
                        break;
                    case 4:
                        ListInConsole(groceries);
                        break;
                    case 5:
                        PrintGroceryList(groceries);
                        break;

                    case 6:
                        cont = false;
                        break;
                    default:
                        break;


                }
                
                
            }

            Console.Read();

            


        }

        private static void ListInConsole(List<Grocery> groceries)
        {
            Console.WriteLine("Here is your current list: ");
            foreach (var g in groceries)
            {
                Console.WriteLine($"{g.FoodName} \t {g.FoodQuanity} \t {g.PricePerItem} \t ${g.TotalPrice}");
            }
        }

        private static void PrintGroceryList(List<Grocery> data)
        {
            using (StreamWriter sw = new StreamWriter(FILE_PATH))
            {
                //write line-by-line from the list
                foreach(var g in data)
                {
                    sw.WriteLine($"{g.FoodName} \t {g.FoodQuanity} \t {g.PricePerItem} \t ${g.TotalPrice}");
                }
            }
        }


        private static void AddGroceries(List<Grocery> groceries)
        {
            //Console.WriteLine("How many items do you want to add?");
            //int totalItems = int.Parse(Console.ReadLine());
            //for (int i = 0; i < totalItems; i++)
            
            bool cont2 = true;

            while(cont2)
            {
                Console.WriteLine("What item are you adding?");
                string name = Console.ReadLine();
                Console.WriteLine("How many are you buying?");
                int quanity = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the price of this item");
                double price = double.Parse(Console.ReadLine());
                double total = quanity * price;
                Grocery grocery = new()
                {
                    FoodName = name,
                    FoodQuanity = quanity,
                    PricePerItem = price,
                    TotalPrice = total,
                };
                groceries.Add(grocery);
                Console.WriteLine("Would you like to add another item? (yes or no)");
                string menuChoice2 = Console.ReadLine();
                menuChoice2.ToLower();
                bool goodChoice = true;
                while(goodChoice)
                {
                    if (!menuChoice2.StartsWith("yes") && !menuChoice2.StartsWith("no"))
                    {
                        Console.WriteLine("Incorrect entry, please try again");
                        menuChoice2 = Console.ReadLine();
                    }
                    else 
                    {
                        if (menuChoice2.StartsWith("y"))
                        {
                            goodChoice = false;
                            break;
                        }
                        else
                        {
                            goodChoice=false;
                            cont2 = false;
                        }
                    }
                }
               


            }
            
                //groceries.Add(new Grocery(name, quanity, price, total));
            
        }
    }
}

//public class Program
//{
//    private const string FILE_PATH = @"C:\Data\Live\SimpleFileIO.tx
//    public static void Main(string[] args)
//    { 
//        //List of string [seed data]
//        var myStrings = new List<string>();
//        for (int i = 0; i < 10; i++)
//        { 
//            myStrings.Add($"Line Number { i }");
//        }
////write it to a text file (line-by-line)
//WriteToTextFile(myStrings);
////read the text file (line-by-line)
//var tempList = ReadFromTextFile(FILE_PATH);
////output the file to the screen
//foreach (var s in tempList)
//{
//    Console.WriteLine($"From Text File: {s}");
//}
//Console.WriteLine("Program has completed");
//    }
//    private static void WriteToTextFile(List<string> data)
//{
//    //open the file --
//    //    need a path to open

//}
//private static List<string> ReadFromTextFile(string path)
//{
//    //instantiate a new list
//    List<string> myFileData = new List<string>();
//    //open the file
//    using (StreamReader reader = new StreamReader(path))
//    {
//        //read line-by-line
//        //put each line into the list
//        while (!reader.EndOfStream)
//        {
//            var nextLine = reader.ReadLine();
//            myFileData.Add(nextLine);
//        }
//    }
//    //return the list
//    return myFileData;
//}
//}