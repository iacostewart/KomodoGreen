using System;

namespace KomodoContracts
{
    public interface IConsole
    {
        void WriteLine(string message);
        void Write(string message);
        string ReadLine();
        void WriteLine(Object o);
    }
}