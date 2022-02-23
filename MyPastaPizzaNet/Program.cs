using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPastaPizzaNet
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDaoStub orderDao = new OrderDaoStub();
            OrderService orderService = new OrderService(orderDao);

            // Add an order
            try
            {
                var joe = new Customer(3, "Joe Doe");
                orderService.Add(new Order
                {
                    Customer = joe,
                    Choices = new List<IChoice>
                    {
                        MockData.Lemonade,
                        MockData.Cake,
                        MockData.Coffee,
                        MockData.IceCream,
                        new MainCourse(MockData.Lasagne, Size.Large)
                    },
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
