using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class DesignImplementation
    {
        static Logging DesignObjectlog;
        static DesignImplementation()
        {
            DesignObjectlog = Logging.Instance;
        }
        public void designPrint()
        {
            DesignObjectlog.myLogging("Design Print");
        }
    }
    class Program
    {
        //class I will be having two constructor by default
        //static memeber of class
        static Logging myStaticLog;
        //Instance memeber of class
        Logging myInstanceLog;
        public Program()
        {
            myInstanceLog = Logging.Instance;
        }
        static Program()
        {
            myStaticLog = Logging.Instance;
        }        
        static void Main(string[] args)
        {
            //pagelog = Logging.Instance;
            //Logging pagelog = Logging.Instance;
            //pagelog.myLogging();
            //pagelog.myPrint();
            Program.myStaticLog.myLogging("Program Message");
        }
    }
}
