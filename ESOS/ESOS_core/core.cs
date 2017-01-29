using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESOS_core
{
    
    class core
    {
        //system build version and stability codes
        static int sysver = 010;
        static string sysversion = "0.1.0";
        static bool isstable = false;
        static int stabl = 0;
        /*
        A little note about stability levels:
        0 = builded for testing purpouses, untested, build hourly, VERY unstable
        1 = build for testing purpouses, tested for 1 min, build daily
        2 = Snapshot
    */
        //system properties and configs

        //system onBoot
        internal static void boot()
        {
            Console.WriteLine("Version" + sysversion);
            string stablString = stabl.ToString();
            Console.WriteLine("System stablilty level = " + stablString + " (I'd be happy if you use at leats 4)");
            if (isstable==false) { Console.WriteLine("WARNING!: This Build Is Unstable! Use at Your Own Risk!!!"); }
            Console.WriteLine("");
            Console.WriteLine("Boot complete, now launching console");


        }
        internal static void error(string error) {
            Console.WriteLine("Woops, Looks like something just exploded:");
            Console.WriteLine(error);
            Kernel.BeforeRun();
        }
        internal static void console() {

        }
    }
}
