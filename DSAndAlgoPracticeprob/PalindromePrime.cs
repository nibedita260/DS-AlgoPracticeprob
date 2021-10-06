using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class PalindromePrime
    {
        public static List<int> list = new List<int>();
        public void CheckIsPrimePalindromeAnagrams()
        {
<<<<<<< HEAD
            int n = 400;
            for (int i = 2; i <= n; i++)
            {
                if (n % i != 0 && i%2!=0)
                {
                    list.Add(i);
                }
            }
            foreach (var elem in list)
            {
                if (ISCheckAnagrams(elem) == true && ISCheckPalindrome(elem) == true)
                {
                    Console.WriteLine(elem + " is prime number ,palindrome and andanagrams as well");
                }
                else {
                    Console.WriteLine(elem);
                } 
            }
        }
        public bool ISCheckPalindrome(int num)
        {
            int revNum = 0;
            while (num != 0)
            {
                int digit;
                digit = num % 10;
                num = num / 10;
                revNum = revNum * 10 + digit;
            }
            if (num == revNum)
            {
                return true;
            }
            return false;
        }
        public bool ISCheckAnagrams(int num)
        {
            string str = num.ToString();
            char[] charArr = str.ToCharArray();
            Array.Sort(charArr);
            string res = new string(charArr);
            foreach(var n in list)
            {
                string s = n.ToString();
                char[] charAr = s.ToCharArray();
                Array.Sort(charAr);
                string resStr = new string(charAr);
                if (resStr == res)
                {
=======
            int a = 1, b = 30, i, j, flag;
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
                   // Console.Write(i + " ");
                    list.Add(i);
                }

            }
            foreach (var elem in list)
            {
                if (ISCheckPalindrome(elem)==true && ISCheckAnagrams(elem)==true)
                {
                    Console.WriteLine(elem + " is prime number ,palindrome and andanagrams as well");
                }
            }
        }
        public bool ISCheckPalindrome(int num)
        {
            int n = num;
            int revNum = 0;
            while (num != 0)
            {
                int digit;
                digit = num % 10;
                num = num / 10;
                revNum = revNum * 10 + digit;
            }
            if (n == revNum)
            {
                return true;
            }
            return false;
        }
        public bool ISCheckAnagrams(int num)
        {
            string str = num.ToString();
            char[] charArr = str.ToCharArray();
            Array.Sort(charArr);
            string res = new string(charArr);
            foreach (var n in list)
            {
                string s = n.ToString();
                char[] charAr = s.ToCharArray();
                Array.Sort(charAr);
                string resStr = new string(charAr);
                if (resStr == res)
                {
>>>>>>> UC5-PalindromePrime
                    return true;
                }
            }
            return false;
        }
    }
}