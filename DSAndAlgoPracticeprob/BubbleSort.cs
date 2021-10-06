using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class BubbleSort
    {
        int i, j;
        public void Bsort()
        {
            int[] array = { 1, 7, 9, 3, 6, 4, 8 };
            for (i = 0; i < array.Length - 1; i++)
            {
                for (j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
            foreach (var data in array)
            {
                Console.WriteLine(data);
            }

        }
    }
}
