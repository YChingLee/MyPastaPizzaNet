using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPastaPizzaNet
{
    public class OrderController
    {
        private readonly OrderService service;

        public OrderController(OrderService service)
        {
            this.service = service;
        }

        public View ShowAll()
        {
            var orders = service.GetOrders();
            var view = new ViewAllOrders(orders);
            return view;
        }

        public View Filter(Customer customer)
        {
            var orders = service.GetOrders(customer);
            View view;

            if(orders.Count() == 0)
            {
                string message = $"There are no orders for {customer.Name}";
                view = new View(message);
                return view;
            }
            
            view = new ViewCustomerOrders(orders);
            return view;
        }

        public View GroupByCustomer()
        {
            var groups = service.GroupOrdersByCustomer();
            var view = new ViewOrdersPerCustomer(groups);
            return view;
        }

        public View Add(Order order)
        {
            service.Add(order);
            var view = Filter(order.Customer);
            return view;
        }
    }
}
