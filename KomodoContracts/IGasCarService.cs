using Komodo.Data;

namespace KomodoContracts
{
    public interface IGasCarService
    {
        GasCar CreateGasCar(int employeeID,string make, string model, int year, float numberOfCityMilesPerWeek,
            float numberOfHighwayMilesPerWeek, int milesPerGallon);
        GasCar Update(GasCar gasCar);
        GasCar Delete(GasCar gasCar);
        GasCar AddToList();
    }
}