﻿using System;
using mpp_lab1;
using TracerPart;

namespace MainPart
{
    interface ITracer
    {
            void StartTrace();
            void StopTrace();
            TraceResult GetTraceResult();   
    }
}
