using System;
using System.Linq;

namespace AlgoritmaAnalizi.Core
{
    public static class Helper
    {
        public static int[] CreateAnArray(int minVal = 1, int maxVal = 30, int arrayLength = 1, string desc = "Non-Sorting Array")
        {
            int[] newArray = new int[arrayLength];

            Random randNum = new Random();
            for (int i = 0; i < newArray.Length; i++)
            {
                int newValue = randNum.Next(minVal, maxVal);
                if (newArray.Contains(newValue))
                {
                    i--;
                    continue;
                }
                newArray[i] = newValue;
            }
            WriteArray(newArray, desc: desc);
            return newArray;
        }
        public static void WriteArray(int[] newArray, string desc = "")
        {
            Console.WriteLine("" + desc + ": {0}", string.Join(",", newArray));
        }
    }
}
