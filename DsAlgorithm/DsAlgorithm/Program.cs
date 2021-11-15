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

            #region UC5
            Console.WriteLine("\n UC5");
            int[] a = new int[] { 15, 3, 1, 10, 9, 13 };
            UC5_MergeSort msort = new UC5_MergeSort();
            Console.WriteLine("Unsorted Array");
            msort.Display(a);
            msort.Sort(a, 0, a.Length - 1);
            Console.WriteLine("\n Sorted Array");
            msort.Display(a);
            #endregion

            Console.WriteLine("\n UC6");
            UC6_Anagram.Anagram();

            Console.WriteLine("\n UC7");
            UC7_PrimeNumber.Prime();

            Console.WriteLine("\n UC8");
            UC8_AnagramAndPalindromeNumber uc8 = new UC8_AnagramAndPalindromeNumber();
            uc8.anagramAndPalindrome();

            /*Console.WriteLine("\n UC9");
            UC9_SearchingAndSortingUsingGenerics obj=new UC9_SearchingAndSortingUsingGenerics();
            obj.BubbleSort<int>(1,6,3);*/

            /*Console.WriteLine("\n UC11");
            UC11TaskDoneByMaximumAmount tdma = new UC11TaskDoneByMaximumAmount();
            tdma.tasks();
*/
            Console.WriteLine("\n UC12");
            UC12_RegexReplace.Regex1();

        }
    
    }
}
