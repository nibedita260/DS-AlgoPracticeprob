using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class AnagramsDetection
    {
        public void CheckAnagrams()
        {
            Console.WriteLine("enter first word");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter second word");
            string str2 = Console.ReadLine();
            char[] IstcharArr = str1.ToCharArray();
            char[] SecondcharArr = str2.ToCharArray();
            Array.Sort(IstcharArr);
            Array.Sort(SecondcharArr);
            string val1 = new string(IstcharArr);
            string val2 = new string(SecondcharArr);
            if (val1 == val2)
            {
                Console.WriteLine("two strings are Anagrams");
            }
            else
            {
                Console.WriteLine("two strings are not Anagrams");
            }
        }
    }
}
