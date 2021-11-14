using System;

namespace AlgorithmPrograms
{
    class UC4_Bubblesort
    {
        public static void BubbleSort()
        {
            int[] N = new int[] { 23,11,8,5,45};
            int n = N.Length;
           
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (N[j] > N[j + 1])
                    {

                        int temp = N[j];
                        N[j] = N[j + 1];
                        N[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine("sorted array " + N[i]);

        }
    }
}