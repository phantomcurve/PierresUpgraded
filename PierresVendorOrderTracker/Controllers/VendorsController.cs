using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
    public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      Dictionary<int, Vendor> allVendors = Vendor.GetAllVendors();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index", "Home");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> vendorInformation =  new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.GetVendor(vendorId);
      List<Order> vendorOrders = selectedVendor.GetAllOrders();
      vendorInformation.Add("vendor", selectedVendor);
      vendorInformation.Add("orders", vendorOrders);
      return View(vendorInformation);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderDate, string deliveryDate, string orderPrice)
    {
      decimal price = Convert.ToDecimal(orderPrice);
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, deliveryDate, price);
      Vendor selectedVendor = Vendor.GetVendor(vendorId);
      selectedVendor.AddOrder(newOrder);
      List<Order> vendorOrders = selectedVendor.GetAllOrders();
      Dictionary<string, object> vendorInformation =  new Dictionary<string, object>();
      vendorInformation.Add("vendor", selectedVendor);
      vendorInformation.Add("orders", vendorOrders);
      return View("Show", vendorInformation);
    }
  }
}
  