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
        internal static int sysver = 010;
        internal static string sysversion = "0.1.0";
        internal static bool isstable = false;
        internal static int stabl = 0;
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
            Console.WriteLine("Sucsess! (That ain't gotta pop often :) )");
            Console.WriteLine("Boot complete, now launching console");
            con.begin();

        }
        internal static void error(string error) {
            Console.WriteLine("Woops, Looks like something just exploded:");
            Console.WriteLine(error);
            Console.WriteLine("System now stops. Press any key to reboot");
            Console.ReadKey();
            Cosmos.System.Power.Reboot();

        }
        
    }
}
