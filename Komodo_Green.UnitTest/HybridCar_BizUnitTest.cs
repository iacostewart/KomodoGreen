using System;
using Komodo.Data;
using KomodoGreen.Bizz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Green.UnitTest
{
    [TestClass]
    public class HybridCar_BizUnitTest
    {
        private HybridCarBiz HybridCar;

        [TestInitialize]
        public void Assemble()
        {
            HybridCar = new HybridCarBiz();
            
        }

        [TestMethod]
        public void HybridCarWillCreate_Successful()
        {
            var employeeId = 234;
            var make = "buzz";
            var model = "smartEcar";
            int year = 2000;
            float numberOfCityMilesPerWeek = 200;
            float numberOfHighwayMilesPerWeek = 300;
            int milesPerCharge = 400;

            var actual = HybridCar.CreateHybridCar(employeeId, make, model,year, numberOfHighwayMilesPerWeek,
                numberOfCityMilesPerWeek, milesPerCharge);

            Assert.IsInstanceOfType(actual, typeof(HybridCar));
        }
        
            
        
    }
}
