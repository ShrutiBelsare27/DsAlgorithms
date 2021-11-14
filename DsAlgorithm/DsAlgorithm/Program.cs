using AlgorithmPrograms;
using System;

namespace DsAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "abc";
            int n = S.Length;
            UC1_Permutation.Permute(S, 0, n - 1);

            //UC2
            UC2_BinarySearchWord.BSTWord();

            Console.WriteLine("\n UC3");
            UC3_InsertionSort.InsertionSort();

            Console.WriteLine("\n UC4");
            UC4_Bubblesort.BubbleSort();

            Console.WriteLine("\n UC6");
            UC6_Anagram.Anagram();
        }
    }
}
