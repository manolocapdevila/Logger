using Log.Interfaces;
using Log.Logger;
using Log.Loggers;
using System;

namespace DemoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger log = new ConsoleLogger();

            Console.WriteLine("Creando un log de info");
            log.LogInfo("Este mensaje va por la clase");

            Console.WriteLine("Creando un log de Error");
            log.LogError("Este mensaje va por la clase");

            log = new FileLogger(@"c:\temp\");

            log.LogInfo("Este mensaje va a texto");
            log.LogError("Y este también");
        }
    }
}
