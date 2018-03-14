using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;
using Class_Library;

namespace MyTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AnCustomer = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }
    }
}
    
