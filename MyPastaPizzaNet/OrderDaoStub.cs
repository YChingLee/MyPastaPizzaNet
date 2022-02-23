using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyPastaPizzaNet
{
    public class OrderDaoStub : IDao
    {
        public List<Order> Fetch()
        {
            return MockData.Orders;
        }

        public void Add(Order order)
        {
            MockData.Orders.Add(order);
        }

    }
}