namespace GSM
{
    using System;

    class GSMCallHistoryTest
    {
        public static void GenerateCallHistory()
        {
            // Create an instance of the GSM class
            GSM myGSM = new GSM("G2", "LG", 560m, "Pesho", 
                new Battery("Li-Po", 790, 16, BatteryType.LiIon), new Display(5.2, 16000000));

            //Add few calls
            myGSM.AddCall(new Call(new DateTime(2015, 3, 10, 20, 53, 20), "0881234567", 65));
            myGSM.AddCall(new Call(new DateTime(2015, 3, 9, 15, 25, 47), "0889876543", 130));
            myGSM.AddCall(new Call(new DateTime(2015, 3, 7, 11, 47, 10), "0891112223", 239));
            myGSM.AddCall(new Call(new DateTime(2015, 2, 28, 19, 37, 32), "0988854321", 167));

            // Display the information about the calls
            myGSM.PrintCallHistory();

            //  Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history
            decimal totalPriceOfCalls = myGSM.CalculateCallsPrice(0.37m);
            Console.WriteLine("Total price of calls in the history: {0:0.00}", totalPriceOfCalls);

            // Remove the longest call from the history and calculate the total price again
            Call longestCall = myGSM.CallHistory[0];

            foreach (Call call in myGSM.CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }

            myGSM.DeleteCall(longestCall);

            totalPriceOfCalls = myGSM.CalculateCallsPrice(0.37m);
            Console.WriteLine("Total price of calls in the history after removing the longest call: {0:0.00} \n", totalPriceOfCalls);

            // Finally clear the call history and print it
            myGSM.ClearCallHistory();
            myGSM.PrintCallHistory();        
        }
    }
}
