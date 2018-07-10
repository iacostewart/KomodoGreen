using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo.Data;
using KomodoContracts;

namespace KomodoGreen.Bizz
{
   public  class ElectricCarBiz : IElectricCarService
    {
        private List<ElectricCar> _electicCarList = new List<ElectricCar>();


        public ElectricCar CreateElectricCar(int employeeId, string make, string model, int year, float numberOfCityMilesPerWeek,
            float numberOfHighwayMilesPerWeek, int milesPerCharge)
        {
           return new ElectricCar(employeeId,make,model,year,numberOfCityMilesPerWeek,numberOfHighwayMilesPerWeek,milesPerCharge);
           
        }

        public ElectricCar AddToList(ElectricCar electricCar)
        {
            _electicCarList.Add(electricCar);
            throw new NotImplementedException();
        }

        public List<ElectricCar> Delete(ElectricCar electricCar)
        {
            foreach (var car in _electicCarList)
            {
                if (car.EmployeeId == electricCar.EmployeeId)
                {
                    _electicCarList.Remove(electricCar);
                }
            }
            //parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });
            return _electicCarList;

        }
        public ElectricCar UpdateElectricCarInList(int employeeId)
        {
            throw new NotImplementedException();
        }

        public ElectricCar AddToList()
        {
            throw new NotImplementedException();
        }
    }
}
