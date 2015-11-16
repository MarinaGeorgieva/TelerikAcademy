namespace SimpleChatMQReceiver
{
    using System;
    using System.Threading;

    using IronMQ;
    using IronMQ.Data;

    public class MQReceiver
    {
        public static void Main()
        {
            Client client = new Client(
                "5649e41d9195a800070000bd",
                "ZG4fOe3HxXa8i7sTyVWN");
            Queue queue = client.Queue("Test channel");
            Console.WriteLine("Listening for new messages from IronMQ server:");
            while (true)
            {
                Message message = queue.Get();
                if (message != null)
                {
                    Console.WriteLine(message.Body);
                    queue.DeleteMessage(message);
                }

                Thread.Sleep(100);
            }            
        }
    }
}
