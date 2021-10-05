﻿using System;
using System.Threading;
using MainPart;

namespace mpp_lab1
{

    

    

    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Thread thread = new Thread(program.Method);
            ITracer tracer = new Library.Implementation.Tracer();

            var foo = new Foo(tracer);
            foo.MyMethod();
            thread.Start(tracer);
            thread.Join();

            var result = new JsonSerializer().Serialize(tracer.GetTraceResult());
            IPrinter printer = new FilePrinter(Path.GetFullPath(Path.Combine(GetFolderDirectory(), "json_result.json")));
            printer.Print(result);
            printer = new ConsolePrinter();
            printer.Print(result);

            result = new VXmlSerializer().Serialize(tracer.GetTraceResult());
            printer = new FilePrinter(Path.GetFullPath(Path.Combine(GetFolderDirectory(), "xml_result.xml")));
            printer.Print(result);
            printer = new ConsolePrinter();
            printer.Print(result);

        }

        public void Method(object obj)
        {
            var tracer = (Library.Implementation.Tracer)obj;
            tracer.StartTrace();
            Thread.Sleep(100);
            tracer.StopTrace();
        }

        public static string GetFolderDirectory()
        {
            var projectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            var folderPath = Path.Combine(projectDir, "Result");

            return folderPath;
        }
    }
}
