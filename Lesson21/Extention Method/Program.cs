using System;
using System.Collections.Generic;

namespace Extention_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            var input = Console.ReadLine();
            if(int.TryParse(input, out int result))
            {
                //var isEven = IsEven(result);
                if (result.IsEven())
                {
                    Console.WriteLine($"{result} is even.");
                }
                else
                {
                    Console.WriteLine($"{result} is not even.");
                }
                var list = new List<Road>();
            }
            else
            {
                Console.WriteLine("This number is not integer!");
            }

            int h = 77;
            h.IsEven();
            h.isDevidedBy(7);
            12.isDevidedBy(43);
            Console.ReadLine();

            var roads = new List<Road>();
            for(var i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }

            var roadsName = roads.ConvertToString();
            Console.WriteLine(roadsName);
            Console.ReadLine();
        }
    }
}
