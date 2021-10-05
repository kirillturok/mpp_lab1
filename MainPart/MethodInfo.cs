using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace TracerPart
{
    public class MethodInfo
    {
        [JsonProperty, XmlAttribute("time")] public double Time { get; set; }
        [JsonProperty, XmlAttribute("name")] public string MethodName { get; set; }
        [JsonProperty, XmlAttribute("class")] public string ClassName { get; set; }

        [JsonIgnore] private readonly Stopwatch _stopWatch = new Stopwatch();
        [JsonProperty, XmlElement("methods")] public List<MethodInfo> InnerMethods { get; set; }
        [JsonIgnore] private readonly string _methodPath;

        public MethodInfo(string methodName, string className, string methodPath)
        {
            ClassName = className;
            MethodName = methodName;
            _methodPath = methodPath;
            _stopWatch.Start();
        }

        public void SetInnerMethods(List<MethodInfo> innerMethodsList)
        {
            InnerMethods = innerMethodsList;
        }

        public void CalculateTime()
        {
            _stopWatch.Stop();
            Time = _stopWatch.ElapsedMilliseconds;
        }

        public long GetElapsedTime()
        {
            return _stopWatch.ElapsedMilliseconds;
        }

        public string GetMethodPath()
        {
            return _methodPath;
        }
    }
}
