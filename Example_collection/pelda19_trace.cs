using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        TraceListener t1 = new TextWriterTraceListener(@"C:\Temp\log.txt");
        TraceListener t2 = new ConsoleTraceListener();
        Trace.Listeners.Add(t1);
        Trace.Listeners.Add(t2);
        Trace.TraceInformation("Napló indul");
            // Ide kerül az, amit naplózni szeretnénk.
        Trace.TraceInformation("Napló vége");
        Trace.Flush(); // Ürítjük a napló puffert
        Console.ReadLine();
    }
}