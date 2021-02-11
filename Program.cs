using System;
using System.Collections.Generic;

namespace AddRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // read input

            List<string> products = new List<string>(n); //create List of n elements

            for (int i = 0; i < n; i++)
            {
                string currProd = Console.ReadLine();  //fill the list
                products.Add(currProd);
            }

            products.Sort();  //sort the list and rearange it 
            int count = 0;

            foreach (var item in products )  // print the list 
            {
                count++;
                Console.WriteLine($"{count}.{item}");
            }
        }
    }
}
