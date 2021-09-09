using mpp_lab1;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainPart
{

    public struct TraceResult
    {
        string methodName;
        string className;
        long time;
    }

    class Tracer : ITracer
    {

        private long _timeStart;
        private long _timeStop;
        private string _methodName;
        private string _className;

        public TraceResult GetTraceResult()
        {
            TraceResult traceResult = new TraceResult();
            
            return traceResult;
            //throw new NotImplementedException();
        }

        public void StartTrace()
        {
            throw new NotImplementedException();
        }

        public void StopTrace()
        {
            throw new NotImplementedException();
        }

    }
}
