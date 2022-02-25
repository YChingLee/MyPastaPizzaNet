using System.Collections.Generic;

namespace MyPastaPizzaNet
{
    public interface IOrderDao
    {
        List<Order> Fetch();
        void Add(Order order);
    }
}