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

  }
}