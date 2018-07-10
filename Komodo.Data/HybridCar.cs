using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo.Data
{
    public class HybridCar : Car
    {
        public int MilesPerCharge { get; set; }

        public HybridCar(int employeeId, string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek, int milesPerCharge) : base(employeeId, make, model, year, numberOfCityMilesPerWeek, numberOfHighwayMilesPerWeek)
        {
            MilesPerCharge = milesPerCharge;
        }
    }
}
