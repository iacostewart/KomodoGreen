using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using KomodoContracts;
using KomodoGreen.Bizz;

namespace KomodoGreen
{
    class ProgramUI
    {

        private readonly IConsole _console;
        public ElectricCarBiz ElectricCar;
        public GasCarBiz GasCar;
        public HybridCarBiz HybridCar;




        public ProgramUI(IConsole consoleForAllReadsAndWrites)
        {
            _console = consoleForAllReadsAndWrites;
            ElectricCar = new ElectricCarBiz();
            GasCar = new GasCarBiz();
            HybridCar = new HybridCarBiz();

        }

        public void Run()
        {
            

            bool finished = false;
            do
            {

                _console.WriteLine("Hello to from the _console");
                _console.Write("Command()");
                var command = _console.ReadLine().ToLower();

                if (String.IsNullOrWhiteSpace(command))
                {
                    finished = true;
                }
                else if (command == "")
                {

                }
            } while (!finished);



        }
    }
}
