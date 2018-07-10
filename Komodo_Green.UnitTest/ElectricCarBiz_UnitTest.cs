using System;
using System.Collections.Generic;
using Komodo.Data;
using KomodoGreen.Bizz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Green.UnitTest
{
    [TestClass]
    public class ElectricCarBiz_UnitTest
    {
        private ElectricCar electricCar;
        private ElectricCarBiz _electricCar;
        ElectricCar car = new ElectricCar();

        [TestInitialize]
        public void Arrange()
        {
            _electricCar = new ElectricCarBiz();
            ElectricCar car1  = new ElectricCar();
            var employeeID = 1234;
            string make = "buzbuz";
            string model = "smartEcar";
            int year = 2000;
            float numberOfCityMilesPerWeek = 200;
            float numberOfHighwayMilesPerWeek = 300;
            int milesPerCharge = 400;
        }

        [TestMethod]
        public void CreateElectricCar_Succeeds()
        {
            var employeeID = 234;
            var make = "buzz";
            var model = "smartEcar";
            int year = 2000;
            float numberOfCityMilesPerWeek = 200;
            float numberOfHighwayMilesPerWeek = 300;
            int milesPerCharge = 400;

            //ElectricCarBiz ElectriCarBiz;
            ElectricCarBiz electricCar = new ElectricCarBiz();

            var actual = electricCar.CreateElectricCar(employeeID, make, model, year, numberOfCityMilesPerWeek, numberOfHighwayMilesPerWeek, milesPerCharge);

            Assert.IsInstanceOfType(actual, typeof(ElectricCar));
        }

        [TestMethod]
        public void AddElectricCarToListSucceeds()
        {
           
        }
    }
}
