using AlgoritmaAnalizi.Core;
using System;

namespace AlgoritmaAnalizi.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] searchArr = Helper.CreateAnArray(15, 20, 5, "Arama Yapılan Dizi");
            Console.WriteLine(BinarySearchIterative(searchArr, 16));
        }

        public static string BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return "Bulunduğu Sıra: " + (++mid).ToString();
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Bulunamadı";
        }
    }
}
