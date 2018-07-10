using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KomodoContracts;

namespace KomodoGreen
{
    class RealConsole : IConsole
    {
        public void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Write(string message)
        {
            System.Console.Write(message);
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public void WriteLine(object o)
        {
            System.Console.WriteLine(0.ToString());
        }
    }
}
