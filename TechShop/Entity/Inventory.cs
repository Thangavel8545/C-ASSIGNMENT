using System;

namespace TechShop.Entity
{
    public class Inventory
    {
        private int inventoryId;
        private Product product;
        private int quantityInStock;
        private DateTime lastStockUpdate;

        public int InventoryID { get => inventoryId; set => inventoryId = value; }
        public Product Product { get => product; set => product = value; }
        public int QuantityInStock { get => quantityInStock; set => quantityInStock = value; }
        public DateTime LastStockUpdate { get => lastStockUpdate; set => lastStockUpdate = value; }

        public Product GetProduct() => Product;
        public int GetQuantityInStock() => QuantityInStock;

        public void AddToInventory(int qty) => QuantityInStock += qty;
        public void RemoveFromInventory(int qty) => QuantityInStock -= qty;

        public void UpdateStockQuantity(int newQty)
        {
            QuantityInStock = newQty;
            LastStockUpdate = DateTime.Now;
        }

        public bool IsProductAvailable(int qty) => QuantityInStock >= qty;

        public decimal GetInventoryValue() => QuantityInStock * Product.Price;

        public bool ListLowStockProducts(int threshold) => QuantityInStock < threshold;
        public bool ListOutOfStockProducts() => QuantityInStock == 0;
        public void ListAllProducts() => Console.WriteLine($"{Product.ProductName} - Qty: {QuantityInStock}");
    }
}