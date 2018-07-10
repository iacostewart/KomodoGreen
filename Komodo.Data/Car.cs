using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo.Data
{
    public abstract class Car
    {
        public int EmployeeId { get; private set; }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public float NumberOfCityMilesPerWeek { get; private set; }
        public float NumberOfHighwayMilesPerWeek { get; private set; }
        

        protected Car(int employeeId,string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek)
        {
            EmployeeId = employeeId;
            Make = make;
            Model = model;
            Year = year;
            NumberOfCityMilesPerWeek = numberOfCityMilesPerWeek;
            NumberOfHighwayMilesPerWeek = numberOfHighwayMilesPerWeek;
        }
    }
}


