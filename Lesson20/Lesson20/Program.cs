using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson20
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            var products = new List<Product>();
            for (var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Product" + i,
                    Energy = rnd.Next(10,15)
                };
                products.Add(product);
            }

            var result = from item in products
                         orderby item.Energy
                         where item.Energy < 200
                         select item;

            var result2 = products.Where(item => item.Energy < 5);

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var selectCollection = products.Select(product => product.Energy);
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var orderbyCollection = products.OrderBy(product => product.Energy)
                                            .ThenByDescending(product => product.Name);
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }

            var groupbyCollection = products.GroupBy(product => product.Energy); // Dictionary<int,List<Product>>

            foreach (var group in groupbyCollection)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.WriteLine();
            }

            products.Reverse();

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            var all = products.All(item => item.Energy == 10);
            Console.WriteLine(all);

            var any = products.Any(item => item.Energy == 10);
            Console.WriteLine(any);

            var prod = new Product();
            var contains = products.Contains(prod); // не принадлежит колекции
            Console.WriteLine(all);

            var array = new int[] { 1, 2, 3, 4 };
            var array2 = new int[] { 3, 4, 5, 6 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            var union = array.Union(array2);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var intersect = array.Intersect(array2);
            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            } 
            
            Console.WriteLine();

            var except = array.Except(array2);
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }   
            
            Console.WriteLine();

            var sum = array.Sum();
            var min = products.Min(p => p.Energy);
            var max = products.Max(p => p.Energy);
            var agregate = array.Aggregate((x, y) => x * y);

            var sum2 = array.Skip(1).Take(2).Sum(); //первый елемент пропускаем и берем только 2 следующих { 1, 2, 3, 4 } -> 2,3
            var first = array.First(); // First / FirstOrDefault
            var firstProduct = products.First(product => product.Energy == 10); // берем First елемент
            var last = array.Last(); // Last / LastOrDefault
            var single = products.Single(product => product.Energy == 10); // берем единсвеный елемент (не может повторяться) есть Defult
            var elementAt = products.ElementAt(5); // взять 5 елемент из коллекции есть Defult

            Console.ReadLine();
        }
    }
}
