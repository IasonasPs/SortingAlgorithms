using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms;
using SortingAlgorithms.Interface;

namespace SortingAlgorithms
{
    internal class SelectionSort : Ialgorithm
    {
        public async Task Sort(int[] array)
        {
            sort(array);
        }



        internal static int[] sort(int[] array)
        {
            Print.print(array);
            Console.WriteLine("-----------------------------------");
            int length = array.Length;

            int controlI = 0;
            int controlJ = 0;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"-->i={i}");
                Console.WriteLine("**************************");
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    controlJ++;
                    Console.WriteLine("j=" + j);
                }
                Console.WriteLine("**************************");

                controlI++;
            }
            Console.WriteLine("------------------------------------");
            Print.print(array);
            Console.WriteLine("------------------------------------");
            Console.WriteLine(controlJ + controlI);
            Console.WriteLine("Repetitions of the first loop :" + controlI);
            Console.WriteLine("Repetitions of the second loop :" + controlJ);
            return null;
        }
    }
}
