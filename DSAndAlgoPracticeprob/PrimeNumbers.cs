using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class PrimeNumbers
    {
        public void PrintPrimeNumbers()
        {
<<<<<<< HEAD
            int n = 8;
            int flag = 0;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && i % 2 == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    flag = 1;
                    break;
=======
            int a = 1, b = 100, i, j, flag;
            Console.WriteLine("\nPrime numbers between " +
                              "{0} and {1} are: ", a, b);
            for (i = a; i <= b; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.Write(i + " ");
>>>>>>> UC5-PalindromePrime
                }

            }
            if (flag == 0)
                Console.WriteLine("Number is Prime.");
        }
    }
}
