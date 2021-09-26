using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public int Id { get; private set; }
    private static int CurrentId { get; set; } = 0;
    private List<Order> _vendorOrders = new List<Order> { };

    private static Dictionary<int, Vendor> _allVendors = new Dictionary<int, Vendor>() { };

    public Vendor(string name, string description, string address, string phoneNumber)
    {
      Name = name;
      Description = description;
      Address = address;
      PhoneNumber = phoneNumber;
      CurrentId++;
      Id = CurrentId;

      _allVendors.Add(Id, this);
    }
  }
}

    