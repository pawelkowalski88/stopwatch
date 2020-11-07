using System;
using System.Threading;

namespace stopwatch
{
    class Program
    {
        static TimeSpan time;
        static void Main(string[] args)
        {
            time = new TimeSpan();

            Console.WriteLine("Stopwatch");
            Console.WriteLine();

            ClearCurrentConsoleLine();

            var timer = new Timer(TimerCallback, null, 1000, 1000);

            Console.ReadLine();
        }

        static void TimerCallback(Object stateInfo)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
            Console.WriteLine(time.ToString());
            time = time.Add(TimeSpan.FromSeconds(1));
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
