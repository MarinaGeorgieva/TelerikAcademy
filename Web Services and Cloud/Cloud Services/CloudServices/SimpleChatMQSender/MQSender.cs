namespace SimpleChatMQSender
{
    using System;

    using IronMQ;

    public class MQSender
    {
        public static void Main()
        {
            Client client = new Client(
                "5649e41d9195a800070000bd",
                "ZG4fOe3HxXa8i7sTyVWN");
            Queue queue = client.Queue("Test channel");
            Console.WriteLine("Enter messages to be sent to the IronMQ server:");
            while (true)
            {
                string message = Console.ReadLine();
                queue.Push(message);
                Console.WriteLine("Message sent to the IronMQ server.");
            }
        }
    }
}
