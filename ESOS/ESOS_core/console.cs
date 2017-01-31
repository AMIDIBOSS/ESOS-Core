using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESOS_core
{
    class con
    {
        internal static void begin()
        {
            Console.WriteLine("ESOS runtime console");
            Console.WriteLine("System version " + core.sysversion);
            getComm();
        }

        internal static void getComm()
        {
            Console.Write("ESOS> ");
            var input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            string command = splitInput[0]; 

            if (command == "help") { displayHelp(); }
            else if(command == "about") {

            }
            getComm();
        }

        private static void displayHelp()
        {
            string[] s = {
                "help - Shows help [What you're lookin' at!]",
                "about - Shows info about system (site, creators, ect.)",
                "update - Shows update instructions",
                ""};
            int sl = s.Length;
            for (int i = 0; i <= sl; i++) {
                Console.WriteLine(s[i]);
            }
        }
    }
}
