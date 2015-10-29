namespace LinkedList
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(1);
            list.AddLast(-10);
            list.AddLast(8);
            list.AddFirst(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
