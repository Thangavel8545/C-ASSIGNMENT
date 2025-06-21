namespace TechShop.Entity
{
    public class Product
    {
        private int productId;
        private string productName;
        private string description;
        private decimal price;

        public int ProductID { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price
        {
            get => price;
            set
            {
                if (value >= 0) price = value;
                else throw new ArgumentException("Price cannot be negative.");
            }
        }

        public void GetProductDetails()
        {
            Console.WriteLine($"Product: {ProductName} (ID: {ProductID}), Price: ₹{Price}, Description: {Description}");
        }

        public void UpdateProductInfo(decimal newPrice, string newDesc)
        {
            Price = newPrice;
            Description = newDesc;
        }

        public bool IsProductInStock()
        {
            return true;
        }
    }
}