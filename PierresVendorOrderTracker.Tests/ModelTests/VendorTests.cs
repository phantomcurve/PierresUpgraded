using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    private Vendor _vendorObject;

    [TestCleanup]
    public void Cleanup()
    {
      Vendor.ClearVendors();
    }

    [TestInitialize]
    public void Initialize()
    {
      string vendorName = "Little T";
      string description = "New American Bakery";
      _vendorObject = new Vendor(vendorName, description);
    }

    [TestMethod]
    public void GetAllOrders_NoOrders_EmptyList()
    {
      List<Order> allVendorOrders = _vendorObject.GetAllOrders();
      Assert.AreEqual(0, allVendorOrders.Count);
    }

    [TestMethod]
    public void AddOrder_OrderObject_ListWithOneOrder()
    {
      string orderTitle = "Loaf Order";
      string orderDescription = "5 Loaves - $5.00 each";
      string orderDate = "10/04/2021";
      string deliveryDate = "10/06/2021";
      decimal price = 20.00m;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, deliveryDate, price);
      _vendorObject.AddOrder(newOrder);
      List<Order> allVendorOrders = _vendorObject.GetAllOrders();
      Assert.AreEqual(1, allVendorOrders.Count);
    }

     [TestMethod]
    public void ClearOrders_OneOrder_EmptyList()
    {
      string orderTitle = "Loaf Order";
      string orderDescription = "5 Loaves - $5.00 each";
      string orderDate = "10/04/2021";
      string deliveryDate = "10/06/2021";
      decimal price = 20.00m;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, deliveryDate, price);
      _vendorObject.AddOrder(newOrder);
      _vendorObject.ClearOrders();
      List<Order> allVendorOrders = _vendorObject.GetAllOrders();
      Assert.AreEqual(0, allVendorOrders.Count);
    }

  }
}