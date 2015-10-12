namespace _01_StringBuilder_Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StringBuilderSubstringTest
    {
        public static void Main()
        {
            StringBuilder stringBuilder1 = new StringBuilder("test string builder");
            StringBuilder stringBuilder2 = new StringBuilder("alabala");

            StringBuilder substring1 = stringBuilder1.Substring(5, 6);
            StringBuilder substring2 = stringBuilder1.Substring(3, 10);
            StringBuilder substring3 = stringBuilder2.Substring(0, 4);

            //StringBuilder substring4 = stringBuilder2.Substring(3, 5);     throws Exception
            //StringBuilder substring5 = stringBuilder2.Substring(7, 2);     throws Exception

            Console.WriteLine("Result from substring1: {0}", substring1);
            Console.WriteLine("Result from substring2: {0}", substring2);
            Console.WriteLine("Result from substring3: {0}", substring3);
        }
    }
}
