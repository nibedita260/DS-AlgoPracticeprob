using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class PrimeNumbers
    {
        public void PrintPrimeNumbers()
        {
            int n = 8;
            int flag = 0;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && i % 2 == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime.");
        }
    }
}
