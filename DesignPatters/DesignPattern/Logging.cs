using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPattern
{
    //Singleton pattern implementation
    public class Logging
    {
        private Logging() { }

        private static Logging LoggingInstance;

        public static Logging Instance
        {
            get
            {
                if (LoggingInstance == null)
                {
                    //Only if the object is null
                    LoggingInstance = new Logging();
                    WriteLine("Instance Is Created");
                }
                return LoggingInstance;
            }
        }
        public void myLogging(string msg)
        {
            Console.WriteLine("My logging: {0}", msg);
        }

        public void myPrint()
        {
            WriteLine("Logging Print");
        }

    }
}
