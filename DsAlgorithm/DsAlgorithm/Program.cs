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

            #region UC2
            UC2_BinarySearchWord.BSTWord();
            #endregion
        }
    }
}
