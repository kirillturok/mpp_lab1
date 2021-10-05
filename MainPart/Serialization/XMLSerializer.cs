using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

using System.Xml.Serialization;

namespace TracerPart.Serialization
{
    public class XMLSerializer : ISerializer
    {
        string ISerializer.Serialize(TraceResult traceResult)
        {
            var data = traceResult.GetThreadTraces().Values.ToArray();
            var xmlSerializer = new XmlSerializer(data.GetType());
            var stringWriter = new StringWriter();

            using (var writer = new XmlTextWriter(stringWriter))
            {
                writer.Formatting = Formatting.Indented;
                xmlSerializer.Serialize(writer, data);
            }

            var result = stringWriter.ToString().Replace("ArrayOfThread", "root");

            return result;
        }
    }
}
