using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    public class UC2_BinarySearchWord
    {
        public static void BSTWord()
        {
            string file = File.ReadAllText(@"C:\Users\User\Desktop\DsAlgorithm\DsAlgorithm\DsAlgorithm\UC2_BinaryWord.txt");
            Console.WriteLine("Contenet of file => " + file);
            string[] w = file.Split(",");
            Array.Sort(w);
            Console.WriteLine(" sorted array");
            Display(w);
            Result(file);


            static void Result(string file)
            {
                string[] w = file.Split(",");
                string x = "Horse";
                int result = BST(w, x);
                if (result == -1)
                    Console.WriteLine("Element not present");
                else
                    Console.WriteLine("Element fount at index " + result);
            }
        }
        static int BST(string[] w, string x)
        {
            int start = 0, end = w.Length - 1;
            while (start <= end)
            {
                int m = (start + end) / 2;
                int res = x.CompareTo(w[m]);
                if (res == 0)
                    return m;
                else if (res > 0)
                {
                    start = m + 1;
                    return start;
                }
                else
                {
                    end = m - 1;
                    return end;
                }
            }
            return end;
        }
        public static void Display(string[] w)
        {
            foreach (string wc in w)
            {
                Console.WriteLine(wc);
            }
        }
    }
}