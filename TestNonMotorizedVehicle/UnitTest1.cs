using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NonMotorizedVehicles;
using Structures;


namespace TestMotorizedVehicle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDrivingClass()
        {
            Bicycle coupe = new Bicycle();
            bool isMoving = coupe.Moving(true);
            Assert.AreEqual(false, isMoving);

            bool hasStarted = coupe.Moving(true);
            Assert.IsTrue(hasStarted);

            bool hasStopped = coupe.Moving(false);
            Assert.IsFalse(hasStopped);
        }

        //[TestMethod]
        public void TestIsDrivingStructure()
        {
            Tricycle trike = new Tricycle();
            bool isMoving = trike.Riding(true);
            Assert.AreEqual(false, isMoving);

            bool hasStarted = trike.Riding(true);
            Assert.IsTrue(hasStarted);

            bool hasStopped = trike.Riding(false);
            Assert.IsFalse(hasStopped);
        }
    }
}
