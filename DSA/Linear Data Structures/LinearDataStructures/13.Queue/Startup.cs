namespace Queue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            LinkedQueue<int> linkedQueue = new LinkedQueue<int>();
            for (int i = 0; i < 10; i++)
            {
                linkedQueue.Enqueue(i + 1);
            }

            while (linkedQueue.Count > 0)
            {
                Console.WriteLine(linkedQueue.Dequeue());
            }
        }
    }
}
