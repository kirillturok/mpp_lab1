using System;
using mpp_lab1;

namespace MainPart
{
    interface ITracer
    {
            void StartTrace();

            void StopTrace();

            TraceResult GetTraceResult();   
    }
}
