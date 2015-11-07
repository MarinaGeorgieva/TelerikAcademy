namespace PriorityQueueImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(9);
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(10);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(8);
            priorityQueue.Enqueue(7);

            Console.WriteLine(priorityQueue.Peek());

            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }
        }
    }
}
