using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsertionSort.Algorithms;
using SortingAlgorithms.Algorithms.MergeSort;
using SortingAlgorithms.Interface;

namespace SortingAlgorithms
{
    internal class Program
    {
        #region MyRegion
        //static void Main(string[] args)
        //{

        //    int[] array0 = { 10, 22, 31, 9, 0 };
        //    int[] array1 = { 99,3,12,14,56,45,78,7,2,9,1,0,32,57,58,59,60};
        //    //InsertionSort.Sort(array0);
        //    //SelectionSort.sort(array0);
        //    //BubbleSort.Sort(array0);

        //    Print.print(array1);
        //    myMergeSort.Sort(array1);
        //    Print.print(array1);
        //    mergeSort.Sort(array1);
        //    Print.print(array1);
        //    Console.WriteLine("-----------------------------------");
        //} 
        #endregion

        static readonly Stopwatch timer = new Stopwatch();

        public static async Task Main(string[] args)
        {
           mergeSort mergeSort = new mergeSort();
            myMergeSort myMergeSort = new myMergeSort();
            SelectionSort selectionSort = new SelectionSort();
            await TimeCheck(mergeSort, selectionSort);
            
        }

        private static async Task TimeCheck(Ialgorithm algorithm0, Ialgorithm algorithm1)
        {
            int[] array1 = { 99, 3, 12, 14, 56, 45, 78, 7, 2, 9, 1, 0, 32, 57, 58, 59, 60 };
            for(int i = 0; i < 2; i++)
            {
                await Console.Out.WriteLineAsync("----------------------------------------");
                timer.Start();
                //Console.WriteLine("Program Start -        " + timer.Elapsed.ToString());
                await algorithm0.Sort(array1);
                Console.WriteLine("Validation Performed - " + timer.Elapsed.ToString());
                timer.Restart();
                //Console.WriteLine("Program Start -        " + timer.Elapsed.ToString());
                await algorithm1.Sort(array1);
                Console.WriteLine("Validation Performed - " + timer.Elapsed.ToString());
                await Console.Out.WriteLineAsync("----------------------------------------");
            }
        }
    }
}
