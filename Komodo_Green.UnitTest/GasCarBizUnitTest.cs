using System;
using Komodo.Data;
using KomodoGreen.Bizz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Green.UnitTest
{
    [TestClass]
    public class GasarBizUnitTest
    {
        private GasCarBiz _gasCar;

        [TestInitialize]
        public void Arrange()
        {
            _gasCar = new GasCarBiz();
            var employeeID = 1234;
            string make = "buzbuz";
            string model = "smartEcar";
            int year = 2000;
            float numberOfCityMilesPerWeek = 200;
            float numberOfHighwayMilesPerWeek = 300;
            int milesPerCharge = 400;
        }

        [TestMethod]
        public void CreateGasCarWillSucceed()
        {
            var employeeId = 1234;
            string make = "buzbuz";
            string model = "smartEcar";
            int year = 2000;
            float numberOfCityMilesPerWeek = 200;
            float numberOfHighwayMilesPerWeek = 300;
            int milesPerGallon = 400;
            GasCarBiz gasCar = new GasCarBiz();

            var actual = gasCar.CreateGasCar(employeeId, make, model, year, numberOfCityMilesPerWeek,
                numberOfHighwayMilesPerWeek, milesPerGallon);

            //Assert.IsInstanceOfType(actual, typeof(ElectricCar));
            Assert.IsInstanceOfType(actual, typeof(GasCar));
        }
    }
}
