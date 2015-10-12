namespace ToStringConverter
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            Converter converter = new Converter();
            converter.ConvertBoolToString(true);
        }
    }
}