using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPastaPizzaNet
{
    public class ViewAllOrders: View
    {
        public ViewAllOrders(object data) : base(data)
        { }

        public override StringBuilder Render()
        {
            var orders = (IEnumerable<Order>)Data;
            var output = new StringBuilder();

            if (orders.Count() > 1)
            {
                foreach (var order in orders)
                {
                    output.AppendLine(order.ToString());
                    output.AppendLine(LineBreak);
                }
            }
            else
                output.AppendLine(orders.FirstOrDefault().ToString());

            return output;
        }

    }
}
