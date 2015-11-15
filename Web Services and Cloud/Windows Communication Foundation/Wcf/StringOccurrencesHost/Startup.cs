namespace StringOccurrencesHost
{    
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    using StringOccurrences;

    public class Startup
    {
        public static void Main()
        {
            Uri serviceAddress = new Uri("http://localhost:3003/strings");
            ServiceHost selfHost = new ServiceHost(typeof(StringService), serviceAddress);

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            using (selfHost)
            {
                selfHost.Open();
                Console.WriteLine("The service is started at endpoint " + serviceAddress);

                StringServiceClient client = new StringServiceClient();
                using (client)
                {
                    int result = client.CountOccurrences("ha", "haxhxahahaahax");
                    Console.WriteLine(result);
                }

                Console.WriteLine("Press [Enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
