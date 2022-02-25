using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPastaPizzaNet
{
    public class ViewCustomerOrders: View
    {
        public ViewCustomerOrders(object data) : base(data)
        { }

        public override StringBuilder Render()
        {
            var orders = (IEnumerable<Order>)Data;
            var customer = orders.FirstOrDefault().Customer;
            string header, footer;
            decimal total = 0;
            var output = new StringBuilder();

            // Assign table header and footer
            if (customer.Id == 0)
            {
                header = $"# Orders from unknown customers{Environment.NewLine}";
                footer = $"The total order value:";
            }
            else
            {
                header = $"# Orders from {customer.Name}:{Environment.NewLine}";
                footer = $"The total order value for customer {customer.Name}:";
            }

            // Paint the report
            output.AppendLine(header);
            foreach (var order in orders)
            {
                total += order.GetTotalPrice();
                output.AppendLine(order.ToString());
            }
            output.AppendLine($"{footer} {total} euro");
            output.AppendLine();
            output.AppendLine(new string('=', 60));

            return output;
        }
    }
}
