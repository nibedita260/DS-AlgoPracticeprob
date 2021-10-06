using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class MergeSort
    {
        public void MSort(string[] array, int begin, int mid, int end)
        {
            int l = mid - begin + 1;
            int r = end - mid;
            int i, j;

            string[] L = new string[l];
            string[] R = new string[r];

            for (i = 0; i < l; ++i)
                L[i] = array[begin + i];

            for (j = 0; j < r; ++j)
                R[j] = array[mid + 1 + j];


            i = 0; j = 0;
            int k = begin;
            while (i < l && j < r)
            {
                if (L[i].CompareTo(R[j]) <= 0)
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < l)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < r)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
        public void Sort(string[] array,int begin,int end)
        {
            if (begin < end)
            {
                int mid = (begin + end) / 2;
                Sort(array, begin, mid);
                Sort(array, mid + 1, end);
                MSort(array, begin, mid, end);
            }
        }
        public void Display(string[] array)
        {
            Console.WriteLine("\nSorted array");
            foreach (string sort in array)
            {
                Console.Write(sort + " ");
            }
        }
    }
}
