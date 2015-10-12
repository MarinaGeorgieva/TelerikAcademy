namespace ToStringConverter
{
    using System;

    public class Converter
    {
        private const int MaxCount = 6;

        public void ConvertBoolToString(bool value)
        {
            string valueAsString = value.ToString();
            Console.WriteLine(valueAsString);
        }
    }
}