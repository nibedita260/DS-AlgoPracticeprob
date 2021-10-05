using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class PalindromePrime
    {
        public void CheckPrimePalindrome()
        {
            int n = 1000;
            for (int i = 2; i <= n; i++)
            {
                int num = i, revNum = 0;
                while (num != 0)
                {
                    int digit;
                    digit = num % 10;
                    num = num / 10;
                    revNum = revNum * 10 + digit;
                }
                //check whether the reverse number and i value same or not.
                if (revNum == i)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= i / 2; j++)
                    {

                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                }
            }
        }
    }
}
