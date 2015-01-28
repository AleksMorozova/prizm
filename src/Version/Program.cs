using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Version
{
    class Program
    {
        static int Main(string[] args)
        {
            int ret = -1;
            if (args.Length > 0)
            {
                try
                {
                    Assembly asm = Assembly.LoadFrom(args[0]);
                    Console.WriteLine(asm.GetName().Version);
                    ret = 0;
                }
                catch (SystemException e)
                {
                    Console.Error.WriteLine("Could not load assembly {0}, reason: {1}", args[0], e.Message);
                    ret = -2;
                }
            }
            else
            {
                Console.Error.WriteLine("No arguments. Assembly expected.");
                ret = -3;
            }
            return ret;
        }
    }
}
