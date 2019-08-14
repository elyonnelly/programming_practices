
using System;
using System.Globalization;

namespace Task_1
{
    // класс цифровые часы
    public class Digital_Clock
    {
        // часы [0,23]
        public int Hours { get; set; }
        // минуты [0,59]
        public int Minutes { get; set; }
        // секунды [0,59]
        public int Seconds { get; set; }
        // переопределённый метод ToString()
        public override string ToString()
        {
            int hours = Hours;
            // часы приводим к соответствующему ограничению 
            // (остальные будут и так правильно ограничены)
            // см. public static implicit operator Digital_Clock(Stopwatch counter)
            while (hours >= 24)
                hours -= 24;
            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.Now.Day, hours, Minutes, Seconds);
            return dateTime.ToLongTimeString();
            /* или можно так:
             return dateTime.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
             строка будет одинаковой в любом из случаев
             https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/custom-date-and-time-format-strings
            */
        }
    }
}
