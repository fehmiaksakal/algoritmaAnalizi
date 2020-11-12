using AlgoritmaAnalizi.Core;
using System;
using System.Linq;

namespace AlgoritmaAnalizi.InsertionSort
{
    class Program
    {
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int currentValue = array[i];
                int index = i - 1;

                while (index >= 0 && array[index] > currentValue)
                {
                    SwapArray(ref index, array);
                }
                array[index + 1] = currentValue;
            }
            return array;
        }
        public static void SwapArray(ref int index,int[] array)
        {
            array[index + 1] = array[index];
            index -= 1;
        }
        static void Main(string[] args)
        {
            var parts = Helper.CreateAnArray(15, 50, 5);

            Helper.WriteArray(InsertionSort(parts), desc: "Sorted Array");
            Console.ReadLine();
        }
    }
}
