using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using NLog;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var logger = LogManager.GetLogger("logger1");

            logger.Info("message from main()");

            new Class1().Foo();

            Console.WriteLine("press any key to quit");
            Console.ReadKey();
        }
    }
}
