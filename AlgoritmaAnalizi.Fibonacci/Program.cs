using System;

namespace AlgoritmaAnalizi.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci();
            Console.ReadKey();
        }
        static void Fibonacci()
        {
            int len = 10;
            for (int j = 0; j < len; j++)
            {
                int firstnumber = 0, secondnumber = 1, result = 0;
                if (j == 0) { Console.Write(0 + " "); continue; };  
                if (j == 1) { Console.Write(1 + " "); continue; } 
                for (int i = 2; i <= j; i++)  
                {
                    result = firstnumber + secondnumber;
                    firstnumber = secondnumber;
                    secondnumber = result;
                }
                Console.Write(result + " ");
            }
        }
    }
}
