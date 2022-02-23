using System.Collections.Generic;

namespace MyPastaPizzaNet
{
    public interface IDao
    {
        List<Order> Fetch();
        void Add(Order order);
    }
}