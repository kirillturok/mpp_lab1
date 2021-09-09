using System;

namespace mpp_lab1
{

    public struct TraceResult
    {
        string methodName;
        string className;
        long time;

        /*public long GetTraceResult()
        {
            return time;
        }*/
    }

    public interface ITracer
    {
        void StartTrace();

        void StopTrace();

        TraceResult GetTraceResult();
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
