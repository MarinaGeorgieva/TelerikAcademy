namespace DaysOfWeekClient
{
    using System;

    using DaysOfWeekClient.DayServiceReference;    

    public class Startup
    {
        public static void Main()
        {
            DayServiceClient client = new DayServiceClient();

            using (client)
            {
                var dayOfWeek = client.GetDay(new DateTime(2015, 11, 21));
                Console.WriteLine(dayOfWeek);
            }
        }
    }
}
