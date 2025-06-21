namespace TechShop.Entity
{
    public class OrderDetail
    {
        private int orderDetailId;
        private Order order;
        private Product product;
        private int quantity;

        public int OrderDetailID { get => orderDetailId; set => orderDetailId = value; }
        public Order Order { get => order; set => order = value; }
        public Product Product { get => product; set => product = value; }
        public int Quantity
        {
            get => quantity;
            set
            {
                if (value > 0) quantity = value;
                else throw new ArgumentException("Quantity must be positive.");
            }
        }

        public decimal CalculateSubtotal()
        {
            return Product.Price * Quantity;
        }

        public void GetOrderDetailInfo()
        {
            Console.WriteLine($"OrderDetailID: {OrderDetailID}, Product: {Product.ProductName}, Quantity: {Quantity}, Subtotal: ₹{CalculateSubtotal()}");
        }

        public void UpdateQuantity(int newQuantity)
        {
            Quantity = newQuantity;
        }

        public void AddDiscount(decimal percent)
        {
            Product.Price -= Product.Price * percent / 100;
        }
    }
}