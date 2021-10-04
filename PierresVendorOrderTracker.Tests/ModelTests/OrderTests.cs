using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
      public void OrderConstructor_OrderParameters_OrderObject()
    {
      string orderTitle = "Regular Bread Order";
      string orderDescription = "5 Loaves - $5.00 each";
      string orderDate = "10/04/2021";
      string deliveryDate = "10/05/2021";
      decimal price = 20.00m;

      Order orderObject = new Order(orderTitle, orderDescription, orderDate, deliveryDate, price);
      Assert.AreEqual(typeof(Order), orderObject.GetType());
    }
  }
}