using System;
using TechShop.Entity;

class Program
{
    static void Main(string[] args)
    {
        Customer cust = new Customer
        {
            CustomerID = 1,
            FirstName = "Thangavel",
            LastName = "A",
            Email = "thangavel@example.com",
            Phone = "9876543210",
            Address = "Coimbatore"
        };

        cust.GetCustomerDetails();

        Product prod = new Product
        {
            ProductID = 101,
            ProductName = "Smartphone",
            Description = "5G Android phone",
            Price = 29999
        };

        prod.GetProductDetails();

        Order order = new Order
        {
            OrderID = 5001,
            Customer = cust,
            OrderDate = DateTime.Now
        };
        order.CalculateTotalAmount(29999);
        order.GetOrderDetails();

        OrderDetail od = new OrderDetail
        {
            OrderDetailID = 1,
            Order = order,
            Product = prod,
            Quantity = 1
        };

        od.GetOrderDetailInfo();

        Inventory inventory = new Inventory
        {
            InventoryID = 301,
            Product = prod,
            QuantityInStock = 50,
            LastStockUpdate = DateTime.Now
        };

        inventory.ListAllProducts();
        Console.WriteLine($"Inventory Value: ₹{inventory.GetInventoryValue()}");
    }
}