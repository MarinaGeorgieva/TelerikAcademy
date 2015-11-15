namespace DayOfWeek
{
    using System;
    using System.Globalization;

    public class DayService : IDayService
    {
        public string GetDay(DateTime date)
        {
            var culture = new CultureInfo("bg-BG");
            return culture.DateTimeFormat.GetDayName(date.DayOfWeek);
        }
    }
}
