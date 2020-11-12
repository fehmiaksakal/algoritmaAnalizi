using System;

namespace AlgoritmaAnalizi.PriortyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>(false);
            Random rnd = new Random();
            //enqueue
            for (int i = 0; i < 10; i++)
            {
                int x = rnd.Next(10);
                queue.Enqueue(x, x);
            }
            //dequeue
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.ReadLine();
        }
    }
}
