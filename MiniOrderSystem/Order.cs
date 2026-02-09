using System;

namespace MiniOrderSystem;

using System.Collections.Generic;

public class Order
{
    public int OrderId { get; set; }
    public List<OrderItem> Items { get; set; }
    public decimal TotalAmount { get; set; }
    public string InvoiceNumber { get; set; }
}
