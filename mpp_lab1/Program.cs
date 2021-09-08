using System;

namespace mpp_lab1
{

    struct TraceResult
    {
        string methodName;
        string className;
        long time;
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
