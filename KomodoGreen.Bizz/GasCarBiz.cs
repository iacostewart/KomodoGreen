using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo.Data;
using KomodoContracts;

namespace KomodoGreen.Bizz
{
    public class GasCarBiz : IGasCarService
    {
        private List<ElectricCar> _electicCarList = new List<ElectricCar>();

        public GasCar CreateGasCar(int employeeId,string make, string model, int year, float numberOfCityMilesPerWeek,
            float numberOfHighwayMilesPerWeek, int milesPerGallon)
        {
            return new GasCar(employeeId,make,model,year,numberOfHighwayMilesPerWeek,numberOfCityMilesPerWeek,milesPerGallon);
            throw new NotImplementedException();
        }

        public GasCar Update(GasCar gasCar)
        {
            throw new NotImplementedException();
        }

        public GasCar Delete(GasCar gasCar)
        {
            throw new NotImplementedException();
        }

        public GasCar AddToList()
        {
            throw new NotImplementedException();
        }
    }
}
