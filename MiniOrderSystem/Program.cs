namespace MiniOrderSystem;
class Program
{
    static void Main()
    {
        try
        {
            Product p1 = new Product
            {
                ProductId = 1,
                ProductName = "Book",
                Price = 500,
                Stock = 10
            };

            Customer cust = new Customer
            {
                CustomerId = 1,
                Name = "Devika"
            };

            OrderService service = new OrderService();

            service.AddToCart(cust, p1, 2);

            Order order = service.PlaceOrder(cust);

            System.Console.WriteLine("Order Placed Successfully");
            System.Console.WriteLine("Invoice: " + order.InvoiceNumber);
            System.Console.WriteLine("Total: " + order.TotalAmount);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
