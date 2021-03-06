using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; private set; }
    private static int CurrentId { get; set; } = 0;
    private List<Order> _vendorOrders = new List<Order> { };

    private static Dictionary<int, Vendor> _allVendors = new Dictionary<int, Vendor>() { };

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      CurrentId++;
      Id = CurrentId;

      _allVendors.Add(Id, this);
    }
    public void ClearOrders()
    {
      _vendorOrders.Clear();
    }

    public List<Order> GetAllOrders()
    {
      return _vendorOrders;
    }

    public void AddOrder(Order newOrder)
    {
      _vendorOrders.Add(newOrder);
    }

    public void DeleteOrder(int indexOfOrder)
    {
      _vendorOrders.RemoveAt(indexOfOrder);
    }

    public Order GetOrder(int indexOfOrder)
    {
      return _vendorOrders[indexOfOrder];
    }

    public static void ClearVendors()
    {
      _allVendors.Clear();
    }

    public static Dictionary<int, Vendor> GetAllVendors()
    {
      return _allVendors;
    }

    public static void DeleteVendor(int vendorId)
    {
      _allVendors.Remove(vendorId);
    }

    public static Vendor GetVendor(int vendorId)
    {
      return _allVendors[vendorId];
    }
  }
}

    