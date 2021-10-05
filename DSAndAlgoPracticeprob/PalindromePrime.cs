using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class PalindromePrime
    {
        public static List<int> list = new List<int>();
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
                    bool isPrime = false;
                    for (int j = 2; j <= i ; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = true;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        list.Add(i);
                    }
                }
            }
            foreach(var num in list)
            {
                while (num > 0)
                {
                    int digit = num % 10;

                    // Update the frequency of
                    // the current digit
                    list[digit]++;

                    // Remove the last digit
                    //num = num/10;
                }
                Console.WriteLine(num + " is prime number and palindrome as well");
            }
        }
    }
}
