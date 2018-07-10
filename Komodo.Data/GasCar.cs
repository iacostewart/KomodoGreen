using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo.Data
{
   public class GasCar : Car
    {
        public int MilesPerGallon { get; set; }

        public GasCar(int employeeId, string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek, int milesPerGallon) : base(employeeId, make, model, year, numberOfCityMilesPerWeek, numberOfHighwayMilesPerWeek)
        {
            MilesPerGallon = milesPerGallon;
        }
    }
}
