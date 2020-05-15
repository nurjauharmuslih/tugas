﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface
{
    class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon printer is printing.....");
        }
    }
}