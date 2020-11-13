using AlgoritmaAnalizi.Core;
using System;

namespace AlgoritmaAnalizi.RandomizedQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Helper.CreateAnArray(15, 50, 20);

            RandomizedQuickSort(arr, 0, arr.Length - 1);

            Helper.WriteArray(arr, desc: "Sorted Array");
        }
        public static void RandomizedQuickSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int q = RandomizedPartition(input, left, right);
                RandomizedQuickSort(input, left, q - 1);
                RandomizedQuickSort(input, q + 1, right);
            }
        }
        private static int RandomizedPartition(int[] input, int left, int right)
        {
            Random random = new Random();
            int i = random.Next(left, right);

            int pivot = input[i];
            input[i] = input[right];
            input[right] = pivot;

            return Partition(input, left, right);
        }
        private static int Partition(int[] input, int left, int right)
        {
            int pivot = input[right];
            int temp;

            int i = left;
            for (int j = left; j < right; j++)
            {
                if (input[j] <= pivot)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }
    }

}
