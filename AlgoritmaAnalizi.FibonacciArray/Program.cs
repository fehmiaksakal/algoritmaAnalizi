using AlgoritmaAnalizi.Core;
using System;

namespace AlgoritmaAnalizi.FibonacciArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = Fibonacci(10);
            Helper.WriteArray(b, "Fibonacci Serisi");
            Console.ReadKey();
        }
        public static int[] Fibonacci(int number)
        {
            int[] a = new int[number];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < number; i++)
            {
                a[i] = a[i - 2] + a[i - 1];
            }
            return a;
        }
    }
}
