using System;
using System.Linq;

namespace SortingAlgorithms
{
    public class Print
    {

        public static void print(int[] array)
        {
            Console.Write("Array :");
            array.ToList().ForEach(i => {
                Console.Write($"{i},");
            });
            Console.WriteLine("");
        }
    }
}