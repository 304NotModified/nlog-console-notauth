using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ClassLibrary1
{
    public class Class1
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        public void Foo()
        {
            Logger.Info("log from Class1.Foo()");
        }
    }
}
