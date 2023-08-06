using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms;
using SortingAlgorithms.Interface;

namespace InsertionSort.Algorithms
{
    internal class BubbleSort 
    {

        //int[] array = { 5, 4, 9, 2, 1 };
        public static int[] Sort(int[] array)
        {
            int i, j, temp;
            int length = array.Length;
            bool swapped;

            Print.print(array);
            for (i = 0; i < length - 1; i++)
            {
                swapped = false;
                for (j = 0; j < length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }


            Console.WriteLine("_______________________");
            Print.print(array);





            return null;
        }

    }
}
