using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.Interface;

namespace SortingAlgorithms
{
    internal class InsertionSort 
    {
        public static int[] Sort(int[] array)
        {
            Print.print(array);
            Console.WriteLine("----------------------------------------------");
            int controlI = 0;
            int controlJ = 0;

            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"------>i={i}<-------");
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    Console.WriteLine(" - - - - -Inside while- - - - - ");
                    Print.print(array);
                    Console.WriteLine(" - - - - - - - - - - - - - - - - ");
                    array[j + 1] = array[j];
                    j--;
                    Print.print(array);
                    controlJ++;
                }
                array[j + 1] = key;
                Print.print(array);
                controlI++;

            }
            Console.WriteLine("----------------------------------------------");
            Print.print(array);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(controlJ + controlI);
            return null;
        }
    }
}
