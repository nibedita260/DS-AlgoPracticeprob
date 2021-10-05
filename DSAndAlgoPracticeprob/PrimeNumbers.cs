using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class PrimeNumbers
    {
        public void PrintPrimeNumbers()
        {
            int n = 1000;
            for(int i = 2; i <= n; i++)
            {
                if (n%i==0)
                {
                    Console.WriteLine("Prime Numbers are:" + i);
                }
            }
        }
    }
}
