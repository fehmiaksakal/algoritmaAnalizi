using AlgoritmaAnalizi.Core;
using System;

namespace AlgoritmaAnalizi.MergeSort
{
    class Program
    {
        public static int[] numbers = Helper.CreateAnArray(15, 50, 5);
        public static int curArraylen = numbers.Length - 1;
        public static void MergeMethod(int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tempIndex;
            left_end = (mid - 1);
            tempIndex = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    ChangeArray(temp, tempIndex++, left++);
                else
                    ChangeArray(temp, tempIndex++, mid++);
            }
            while (left <= left_end)
                ChangeArray(temp, tempIndex++, left++);
            while (mid <= right)
                ChangeArray(temp, tempIndex++, mid++);
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        public static void ChangeArray(int[] Arr, int tempIndex, int sideIndex)
        {
            Arr[tempIndex] = numbers[sideIndex];
        }
        public static void SortMethod(int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;//calc. mid point
                SortMethod(left, mid);//take left side --divide left side
                SortMethod((mid + 1), right);//take right side --divide right side
                MergeMethod(left, (mid + 1), right);//merge process --process side
            }
        }
        static void Main(string[] args)
        {
            SortMethod(0, curArraylen);
            Helper.WriteArray(numbers, desc: "Sorted Array");
            Console.Read();
        }
    }
}
