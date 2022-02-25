using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPastaPizzaNet
{
    class Program
    {
        private static void Display(View view)
        {
            Console.Clear();
            Console.WriteLine(view.Render());
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            OrderDaoStub orderDao = new OrderDaoStub();
            OrderService service = new OrderService(orderDao);
            OrderController orderController = new OrderController(service);

            View view;
            // Display orders
            view = orderController.ShowAll();
            Display(view);

            // Display orders from Jan Janssen
            var jan = MockData.JanJanssen;
            view = orderController.Filter(jan);
            Display(view);
            
            // Display orders per customer
            var groups = service.GroupOrdersByCustomer();
            view = new ViewOrdersPerCustomer(groups);
            Display(view);

            // Display orders from Joe
            Customer joe = new Customer(3, "Joe Doe");
            view = orderController.Filter(joe);
            Display(view);

            // Add a new order
            var order = new Order
            {
                Customer = joe,
                Choices = new List<IChoice>
                {
                    MockData.Cake,
                    MockData.Coffee,
                    MockData.Coke,
                    MockData.IceCream
                }
            };
            view = orderController.Add(order);
            Display(view);
        }
    }
}
