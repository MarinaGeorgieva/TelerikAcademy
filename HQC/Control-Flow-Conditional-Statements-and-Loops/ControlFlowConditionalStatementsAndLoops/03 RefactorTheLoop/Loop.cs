namespace _03_RefactorTheLoop
{
    using System;

    public class Loop
    {
        public static void Main()
        {
            int[] array = new int[100];
            int expectedValue = 666;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0)
                {                    
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        isFound = true;
                    }
                }                
            }

            if (!isFound)
            {
                Console.WriteLine("Value Not Found");
            }
        }
    }
}
