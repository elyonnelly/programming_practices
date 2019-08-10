
namespace Task_1
{
    // класс секундомер
    public class Stopwatch
    {
        // автореализуемое свойство - секунды
        public int Seconds { get; set; }
        // перегрузка +
        public static Stopwatch operator +(Stopwatch c1, Stopwatch c2)
        {
            // важно создавать новый экземпляр класса и возвращать ссылку на него
            return new Stopwatch { Seconds = c1.Seconds + c2.Seconds };
        }
        // перегрузка >
        public static bool operator >(Stopwatch c1, Stopwatch c2)
        {
            return c1.Seconds > c2.Seconds;
        }
        // перегрузка <
        public static bool operator <(Stopwatch c1, Stopwatch c2)
        {
            return c1.Seconds < c2.Seconds;
        }
        // неявное приведение к Stopwatch из int
        public static implicit operator Stopwatch(int x)
        {
            return new Stopwatch { Seconds = x };
        }
        // явное приведение к int из Stopwatch
        public static explicit operator int(Stopwatch stopwatch)
        {
            return stopwatch.Seconds;
        }
        // явное приведение к Stopwatch из Digital_Clock
        public static explicit operator Stopwatch(Digital_Clock timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new Stopwatch { Seconds = h + m + timer.Seconds };
        }
        // неявное приведение к Digital_Clock из Stopwatch
        public static implicit operator Digital_Clock(Stopwatch counter)
        {
            // Разбить время на часы , минуты и секунды
            int h = counter.Seconds / 3600;
            int m = counter.Seconds / 60 - h * 60;
            int s = counter.Seconds - m * 60 - h * 3600;
            return new Digital_Clock { Hours = h, Minutes = m, Seconds = s };
        }
        // переопределённый метод ToString()
        public override string ToString()
        {
            return $"{Seconds}";
        }
    }
}
