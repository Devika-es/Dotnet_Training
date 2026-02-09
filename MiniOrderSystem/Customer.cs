using System;

namespace MiniOrderSystem;

using System.Collections.Generic;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public List<OrderItem> Cart { get; set; } = new List<OrderItem>();
}
