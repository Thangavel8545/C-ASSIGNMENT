using System;

namespace TechShop.Entity
{
    public class Order
    {
        private int orderId;
        private Customer customer;
        private DateTime orderDate;
        private decimal totalAmount;

        public int OrderID { get => orderId; set => orderId = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }

        public void CalculateTotalAmount(decimal amount)
        {
            TotalAmount = amount;
        }

        public void GetOrderDetails()
        {
            Console.WriteLine($"OrderID: {OrderID}, Customer: {Customer.FirstName}, Date: {OrderDate}, Amount: ₹{TotalAmount}");
        }

        public void UpdateOrderStatus(string status)
        {
            Console.WriteLine($"Order {OrderID} status updated to: {status}");
        }

        public void CancelOrder()
        {
            Console.WriteLine($"Order {OrderID} has been cancelled.");
        }
    }
}