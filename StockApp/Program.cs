using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StockApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ivan's Stock Reporting App V1.0");

            StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\ivans\source\repos\StockApp\StockApp\stock.csv"));
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            List<string> listC = new List<string>();
            
            while (!reader.EndOfStream)
            {
                
                var line = reader.ReadLine(); //not exactly sure why we use var here. Need to read up on Var
                var values = line.Split(',');

                listA.Add(values[0]); //first value in the line gets added to listA. So listA contains all the IDs
                listB.Add(values[1]); //Secnd value in the line gets added to listB. So listB contains all the item Names
                listC.Add(values[2]); //Third value in the line gets added to listB. So listC contains all the item quantities
            }
             

            if (args[0] == "-help")
            {
                Console.WriteLine("Type 'StockApp.exe -help' to view available commands.");
                Console.WriteLine("Type 'StockApp.exe -view <ItemID>' to view the name of the item with that ID.");
                Console.WriteLine("Type 'StockApp.exe -stock <itemID>' to show the quantity in stock of the item with that ID.");

            } else if(args[0] == "-view")
            {
                if (args[1] == listA[0])
                {
                    Console.WriteLine("This item ID is for: " + listB[0]);
                } else if (args[1] == listA[1])
                {
                    Console.WriteLine("This item ID is for: " + listB[1]);
                } else if (args[1] == listA[2])
                {
                    Console.WriteLine("This item ID is for: " + listB[2]);
                } else if (args[1] == listA[3])
                {
                    Console.WriteLine("This item ID is for: " + listB[3]);
                } else if(args[1] == listA[4])
                {
                    Console.WriteLine("This item ID is for: " + listB[4]);
                }
         

            } else if(args[0] == "-stock")
            {
                if (args[1] == listA[0] || args[1] == listB[0])
                {
                    Console.WriteLine("You have: " + listC[0] + " " + listB[0]);
                }
                else if (args[1] == listA[1] || args[1] == listB[1])
                {
                    Console.WriteLine("You have: " + listC[1] + " " + listB[1]);
                }
                else if (args[1] == listA[2] || args[1] == listB[2])
                {
                    Console.WriteLine("You have: " + listC[2] + " " + listB[2]);
                }
                else if (args[1] == listA[3] || args[1] == listB[3])
                {
                    Console.WriteLine("You have: " + listC[3] + " " + listB[3]);
                }
                else if (args[1] == listA[4] || args[1] == listB[4])
                {
                    Console.WriteLine("You have: " + listC[4] + " " + listB[4]);
                }


            };


        }
    }
}
