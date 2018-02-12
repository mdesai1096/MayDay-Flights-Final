using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstFlights
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //test to see if it exists
            Assert.IsNotNull(AnFlight);
        }
    }
}
