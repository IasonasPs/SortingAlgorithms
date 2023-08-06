using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.Interface;

namespace SortingAlgorithms.Algorithms.MergeSort
{
    internal class myMergeSort : Ialgorithm
    {
        public  async Task Sort(int[] array)
        { 
            SortArray(array,0,array.Length-1);            
        }

        public static int[] SortArray(int[] array, int left, int right)
        {
            if(left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
            return array;
        }

        public static void Merge(int[] array, int left, int middle, int right)
        {

            int leftArrayLength = middle - left + 1;
            int rightArrayLength = right - middle;

            int[] L = new int[leftArrayLength];
            int[] R = new int[rightArrayLength];

            #region Populating L,R arrays
            for(int i = 0; i < leftArrayLength; i++)
            {
                L[i] = array[left + i];
            }

            for(int j = 0; j < rightArrayLength; j++)
            {
                R[j] = array[j + middle + 1];
            }
            #endregion

            int l = 0, r = 0, k = 0;
            int[] temp = new int[leftArrayLength + rightArrayLength];


            while(k < temp.Length && r < R.Length && l < L.Length)
            {
                if(L[l] > R[r])
                {
                    temp[k] = R[r];
                    r++;
                }
                else
                {
                    temp[k] = L[l];
                    l++;
                }
                k++;
            }

            while(l < L.Length)
            {
                temp[k] = L[l];
                l++;
                k++;
            }

            while(r < R.Length)
            {
                temp[k] = R[r];
                r++;
                k++;
            }

            //Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            //Print.print(temp);
            //Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            temp.CopyTo(array, left);
        }
    }
}
