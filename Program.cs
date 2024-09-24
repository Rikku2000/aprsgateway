using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace APRSForwarder
{
    class Program
    {        
        static void Main(string[] args)
        {
            APRSGateWay gateway = new APRSGateWay();                        
            gateway.Start();
            // gateway.Stop();
        }
    }
}
