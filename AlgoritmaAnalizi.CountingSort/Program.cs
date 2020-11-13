using AlgoritmaAnalizi.Core;
using System;

namespace AlgoritmaAnalizi.CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2] { 0, 1 };//Helper.CreateAnArray(15, 50, 20);

            Sort(arr);

            Helper.WriteArray(arr, "Sorted Array");

            Console.ReadLine();
        }

        static void Sort(int[] array)
        {
            int length = array.Length;

            //Create a new "output" array
            int[] output = new int[length];

            //Create a new "counting" array 
            //which stores the count of each unique number
            int[] count = new int[100];
            for (int i = 0; i < 100; ++i)
            {
                count[i] = 0;
            }
            for (int i = 0; i < length; ++i)
            {
                ++count[array[i]];
            }

            //Change count[i] so that count[i] now contains the   
            //actual position of this character in the output array.
            for (int i = 1; i <= 99; ++i)
            {
                count[i] += count[i - 1];
            }

            //Build the output array.
            //To make this sorting algorithm stable, 
            //we are operating in reverse order. 
            for (int i = length - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                --count[array[i]];
            }

            //Copy the output array to the final array.
            for (int i = 0; i < length; ++i)
            {
                array[i] = output[i];
            }
        }
    }
}
