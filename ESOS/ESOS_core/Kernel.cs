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
            core.boot();
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
