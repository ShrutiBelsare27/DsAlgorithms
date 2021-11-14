using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class UC3_InsertionSort
    {
        public static void InsertionSort()
        {
            string[] arr = new string[] { "Ant", "Bird", "Cat", "Mouse", "Horse" };
            int n = arr.Length;
            sort(arr, n);
            Display(arr, n);

            static void sort(string[] arr, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                for (int i = 1; i < n; i++)
                {
                    string temp = arr[i];
             
                    int j = i - 1;
                    while (j >= 0 && temp.Length < arr[j].Length)
                    {

                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = temp;
                }
            }
            static void Display(string[] arr, int n)
            {
                Console.WriteLine("\n Sorted Array is : ");
                for (int i = 0; i < n; i++)
                { Console.Write(arr[i] + " "); }
            }
        }
    }
}