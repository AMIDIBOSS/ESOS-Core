using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace ESOS_core
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Starting ESOS...");
            
        }

        protected override void Run()
        {
            core.boot();

        }
    }
}
