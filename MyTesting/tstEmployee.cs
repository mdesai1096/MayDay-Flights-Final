using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstEmployee
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //test to see if it exists
            Assert.IsNotNull(AnEmployee);
        }
    }
}
