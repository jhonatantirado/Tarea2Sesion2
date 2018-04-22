using System;
using System.Threading;
using System.Diagnostics;

namespace NotacionBigO.DS
{
    public class DataStructures {
        private static int SIZE_LOG_LINES = 100000;
        private static int SIZE_UNIQUE_IPS = 90001;
        private static LogReader logReader = new LogReader(SIZE_LOG_LINES, SIZE_UNIQUE_IPS);

        public void execute(string[] args) {
            Console.WriteLine("Reading all log entries...");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int sizeLogLines = logReader.readAllLogs();
            Console.WriteLine("Number of lines: " + sizeLogLines);
            long ts = stopWatch.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed in milliseconds: " + ts);

            Console.WriteLine("\nProcessing unique IPs...");
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            int sizeUniqueIps = logReader.getSizeUniqueIps();
            Console.WriteLine("Number of unique IPs: " + sizeUniqueIps);
            ts = stopWatch2.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed in milliseconds: " + ts);
        }
    }
}