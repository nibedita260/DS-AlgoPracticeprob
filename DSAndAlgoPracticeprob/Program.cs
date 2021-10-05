﻿using System;

namespace DSAndAlgoPracticeprob
{
    class Program
    {
        static void Main(string[] args)
        {
            int options;
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("choose 1.PermutationOfString 2.WordSearch 3.AnagramDetection");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("enter a string");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        PermutationString permutationString = new PermutationString();
                        permutationString.PrintPermutations(str,0,n-1);
                        break;
                    case 2:SearchWord searchWord = new SearchWord();
                        searchWord.IsWordFound();
                        break;
                    case 3:AnagramsDetection anagramsDetection = new AnagramsDetection();
                        anagramsDetection.CheckAnagrams();
                        break;
                    default:Console.WriteLine("choose valid option");
                        break;
                }
            }
        }
    }
}
