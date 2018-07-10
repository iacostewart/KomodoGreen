using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Komodo.Data;
using KomodoContracts;

namespace KomodoGreen.Bizz
{
    public class HybridCarBiz : IHybridCarService
    {
        public HybridCar CreateHybridCar(int employeeId, string make, string model, int year, float numberOfCityMilesPerWeek,
            float numberOfHighwayMilesPerWeek, int milesPerCharge)
        {
            return new HybridCar(employeeId,make,model,year,numberOfCityMilesPerWeek,numberOfHighwayMilesPerWeek,milesPerCharge);
        }

        public HybridCar Upadate(HybridCar hybridCar)
        {
            throw new NotImplementedException();
        }

        public HybridCar Delete(HybridCar hybridCar)
        {
            throw new NotImplementedException();
        }

        public GasCar AddToList()
        {
            throw new NotImplementedException();
        }
    }
}
