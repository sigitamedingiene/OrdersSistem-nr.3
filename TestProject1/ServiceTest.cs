using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderService_DataAccess;
using OrderSistem_Business;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void ServiceListIsNotNullTestValid()
        {
            ServiceRepository service = new ServiceRepository();
            List<Service> serviceList = service.Retrieve();

            Assert.IsNotNull(serviceList);


        }

        public void ServicePrieceTest()
        {
            ServiceRepository service = new ServiceRepository();
            List<Service> serviceList = service.RetrieveServicePrice(9.90m);

            for (int i = 0; i < serviceList.Count; i++)
            {

                Assert.IsTrue(serviceList[i].Price > 9.90m);

            }

        }

    }
}
