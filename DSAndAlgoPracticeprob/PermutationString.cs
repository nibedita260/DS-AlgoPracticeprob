using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgoPracticeprob
{
    class PermutationString
    {
        public void PrintPermutations(string str,int startindex,int endindex)
        {
                if (startindex==endindex)
                {
                    Console.WriteLine("Permutation of given string is:" + str);
                }
                else
                {
                    for (int j = startindex; j <= endindex; j++)
                    {
                        str = Swap(str, startindex, j);
                        PrintPermutations(str, startindex + 1, endindex);
                        str = Swap(str, startindex, j);
                    }
                }
        }
        public static String Swap(string s,int i,int j)
        {
            char temp;
            char[] charArr = s.ToCharArray();
            temp = charArr[i];
            charArr[i] = charArr[j];
            charArr[j] = temp;
            string res = new string(charArr);
            return res;
        }
    }
}
