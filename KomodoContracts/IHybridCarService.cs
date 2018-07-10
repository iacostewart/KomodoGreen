using Komodo.Data;

namespace KomodoContracts
{
    public interface IHybridCarService
    {
        HybridCar CreateHybridCar(int employeeId,string make, string model, int year, float numberOfCityMilesPerWeek,
            float numberOfHighwayMilesPerWeek, int milesPerCharge);
        HybridCar Upadate(HybridCar hybridCar);
        HybridCar Delete(HybridCar hybridCar);
        GasCar AddToList();
    }
}