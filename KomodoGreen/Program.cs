﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new ProgramUI(new RealConsole());
            ui.Run();
        }
    }
}
