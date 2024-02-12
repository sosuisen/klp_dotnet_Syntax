namespace Syntax
{
    internal class Order
    {
        private int orderId;
        private string customerName;
        private DateTime orderDate;

        public Order(int orderId, string customerName, DateTime orderDate)
        {
            this.orderId = orderId;
            this.customerName = customerName;
            this.orderDate = orderDate;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {orderId}, Customer: {customerName}, Date: {orderDate.ToShortDateString()}");
        }
    }
}