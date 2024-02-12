namespace Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(1, "Alan Kay", DateTime.Now);
            Order order2 = new Order(2, "Ted Nelson", DateTime.Now.AddDays(1));

            order.DisplayOrder();
            order2.DisplayOrder();
        }
    }
}