using System.Collections.Generic;
using System.Threading;
using MainPart;
using NUnit.Framework;
using TracerPart;

namespace TestProject1
{
    class Class1
    {
        readonly ITracer _tracer = new Tracer();
        readonly int _threadsCount = 2;
        readonly List<Thread> _threads = new List<Thread>();

        public void Method()
        {
            _tracer.StartTrace();
            Thread.Sleep(100);
            _tracer.StopTrace();
        }

        [Test]
        public void ThreadCount()
        {
            for (int i = 0; i < _threadsCount; i++)
            {
                _threads.Add(new Thread(Method));
            }
            foreach (Thread thread in _threads)
            {
                thread.Start();
                thread.Join();
            }
            TraceResult traceResult = _tracer.GetTraceResult();
            Assert.AreEqual(_threadsCount , traceResult.GetThreadTraces().Count);
        }

    }
}
