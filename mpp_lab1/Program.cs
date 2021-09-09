using System;

namespace mpp_lab1
{

    struct TraceResult
    {
        string methodName;
        string className;
        long time;

        public long GetTraceResult()
        {
            return time;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("привет");
            string str = Console.ReadLine();
            Console.WriteLine("sbdfbd|||{0}|||fbd",str);
            Console.ReadKey(true);
        }
    }
}
