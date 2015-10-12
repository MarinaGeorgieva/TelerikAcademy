namespace GSM
{
    using System;

    class GSMTest
    {
        public static void GenerateGSMs()
        {
            GSM htc = new GSM("One", "HTC", 750m, "Sasho",
                new Battery("Li-Ion", 500, 18, BatteryType.LiIon), new Display(4.7, 16000000));
            GSM samsung = new GSM("S5", "Samsung", 1000m, "Mariya",
                new Battery("Li-Ion", 390, 21, BatteryType.LiIon), new Display(5.1, 16000000));
            GSM sony = new GSM("Xperia Z3", "Sony", 900m, "Gergana",
                new Battery("Li-Ion", 740, 16, BatteryType.LiIon), new Display(5.2, 16000000));
            GSM nokia = new GSM("Lumia 930", "Nokia", 540m, "Todor",
                new Battery("Li-Ion", 432, 11, BatteryType.LiIon), new Display(5.0, 16000000));

            GSM[] gsmArray = new GSM[] { htc, samsung, sony, nokia, GSM.Iphone4S };

            foreach (var gsm in gsmArray)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }
        }
    }
}
