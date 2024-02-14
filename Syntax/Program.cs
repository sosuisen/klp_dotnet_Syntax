namespace Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(1, "Alan Kay", DateTime.Now);
            Order order2 = new Order(2, "Ted Nelson", DateTime.Now.AddDays(1));

            order1.DisplayOrder();
            order2.DisplayOrder();
        }
    }
}