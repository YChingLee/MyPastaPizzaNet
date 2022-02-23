using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace MyPastaPizzaNet
{
    public class OrderService
    {
        private readonly IDao db;

        public OrderService(IDao db) => this.db = db;

        public IEnumerable<Order> GetOrders()
        {
            var orders = db.Fetch();
            orders.ForEach(o => o.Choices.Sort());
            return orders;
        }

        public IEnumerable<Order> GetOrders(Customer customer)
        {
            var query = GetOrders()
                .Where(o => o.Customer.Name == customer.Name);

            if (query.Count() == 0)
                throw new Exception($"Orders are not found for customer {customer.Name}.");

            return query;
        }

        public IEnumerable<IGrouping<Customer, Order>> GroupOrdersByCustomer()
        {
            var query = GetOrders().GroupBy(order => order.Customer);
            return query;
        }

        public void Add(Order order)
        {
            // Sorting order items by product type: First all main courses,thendrinks,thendesserts
            order.Choices.Sort();
            order.Id = GetOrders().Max(o => o.Id) + 1;
            db.Add(order);
        }
    }
}