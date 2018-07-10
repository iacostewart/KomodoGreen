using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo.Data;

namespace KomodoContracts
{
  public  interface IElectricCarService
    {
       ElectricCar CreateElectricCar(int employeeID, string make, string model, int year, float numberOfCityMilesPerWeek, 
             float numberOfHighwayMilesPerWeek, int milesPerCharge);
       ElectricCar UpdateElectricCarInList(int employeeID);
       List<ElectricCar> Delete(ElectricCar electricCar);
       ElectricCar AddToList(ElectricCar electricCar);
    }
}
