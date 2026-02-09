using System;

namespace MiniOrderSystem;

public class OrderService
{
       public void AddToCart(Customer cust, Product product, int quantity)
    {
        if (product == null)
            throw new InvalidProductException("Product is invalid");

        if (quantity <= 0)
            throw new InvalidQuantityException("Quantity must be greater than zero");

        OrderItem existingItem = cust.Cart.FirstOrDefault(i => i.Product.ProductId == product.ProductId);

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            cust.Cart.Add(new OrderItem
            {
                Product = product,
                Quantity = quantity
            });
        }
    }
     public Order PlaceOrder(Customer cust)
    {
        if (cust.Cart.Count == 0)
            throw new EmptyCartException("Cart is empty");

        foreach (var item in cust.Cart)
        {
            if (item.Product.Stock < item.Quantity)
                throw new InsufficientStockException(
                    "Insufficient stock for " + item.Product.ProductName);
        }

 
        foreach (var item in cust.Cart)
        {
            item.Product.Stock -= item.Quantity;
        }

       
        decimal total = cust.Cart.Sum(i => i.Product.Price * i.Quantity);

        Order order = new Order
        {
            OrderId = new Random().Next(1000, 9999),
            Items = cust.Cart,
            TotalAmount = total,
            InvoiceNumber = GenerateInvoice()
        };

    
        Payment payment = ProcessPayment(total);
        if (payment.Status != "Success")
            throw new PaymentFailedException("Payment failed");

       
        cust.Cart = new List<OrderItem>();

        return order;
    }

    private string GenerateInvoice()
    {
        return "INV-" + DateTime.Now.Ticks;
    }

    private Payment ProcessPayment(decimal amount)
    {
        if (amount <= 0)
        {
            return new Payment
            {
                Amount = amount,
                Status = "Failed"
            };
        }

        return new Payment
        {
            Amount = amount,
            Status = "Success"
        };
    }

}


class InvalidProductException : Exception
{
    public InvalidProductException(string msg) : base(msg) { }
}

class InvalidQuantityException : Exception
{
    public InvalidQuantityException(string msg) : base(msg) { }
}

class EmptyCartException : Exception
{
    public EmptyCartException(string msg) : base(msg) { }
}

class InsufficientStockException : Exception
{
    public InsufficientStockException(string msg) : base(msg) { }
}

class PaymentFailedException : Exception
{
    public PaymentFailedException(string msg) : base(msg) { }
}
