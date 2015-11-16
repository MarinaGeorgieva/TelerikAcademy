namespace SimpleChatPubNub
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;
    

    using PubNubMessaging.Core;
    

    public class Startup
    {
        public static void Main()
        {
            // Start the HTML5 Pubnub client
            Process.Start("..\\..\\PubNub-HTML5-Client.html");

            Thread.Sleep(2000);

            Pubnub pubnub = new Pubnub(
                "pub-c-dfec8b59-9beb-4446-8230-236e56a93b34",               // PUBLISH_KEY
                "sub-c-1e7a2bac-8c71-11e5-84ee-0619f8945a4f",               // SUBSCRIBE_KEY
                "sec-c-MzI4MDA3ZWQtZDE5ZC00ODkxLTlmYTItYWZiZjE0MDY5Zjdi",   // SECRET_KEY
                "",
                true
            );

            string channel = "test-channel";

            // Publish a sample message to Pubnub
            pubnub.Publish<string>(
                channel,
                "Hello Pubnub!",
                DisplayReturnMessage,
                DisplayErrorMessage);
            
            // Subscribe for receiving messages (in a background task to avoid blocking)
            Task t = new Task(
                () =>
                pubnub.Subscribe<string>(
                    channel,
                    DisplaySubscribeReturnMessage,
                    DisplaySubscribeConnectStatusMessage,
                    DisplayErrorMessage
                )
            );
            t.Start();

            // Read messages from the console and publish them to Pubnub
            while (true)
            {
                Console.Write("Enter a message to be sent to Pubnub: ");
                string msg = Console.ReadLine();
                pubnub.Publish<string>(
                    channel, 
                    msg,
                    DisplayReturnMessage, 
                    DisplayErrorMessage);
                Console.WriteLine("Message {0} sent.", msg);
            }
        }

        private static void DisplayReturnMessage(string result)
        {
            Console.WriteLine("REGULAR CALLBACK:");
            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static void DisplayErrorMessage(PubnubClientError result)
        {
            Console.WriteLine();
            Console.WriteLine(result.Description);
            Console.WriteLine();
        }

        private static void DisplaySubscribeReturnMessage(string result)
        {
            Console.WriteLine("SUBSCRIBE REGULAR CALLBACK:");
            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static void DisplaySubscribeConnectStatusMessage(string result)
        {
            Console.WriteLine("SUBSCRIBE CONNECT CALLBACK:");
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
