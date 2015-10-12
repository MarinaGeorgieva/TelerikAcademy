namespace _01_ClassChef
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            //Potato potato;
            ////... 
            //if (potato != null)
            //    if (!potato.HasNotBeenPeeled && !potato.IsRotten)
            //        Cook(potato);

            Potato potato = new Potato();
            //... 

            bool isPeeled = potato.IsPeeled;
            bool isRotten = potato.IsRotten;

            if (potato != null)
            {
                if (isPeeled && !isRotten)
                {
                    potato.Cook();
                }                    
            }                
        }
    }
}
