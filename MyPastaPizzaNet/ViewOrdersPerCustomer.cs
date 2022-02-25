using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPastaPizzaNet
{
    public class ViewOrdersPerCustomer: View
    {
        public ViewOrdersPerCustomer(object data): base(data)
        { }

        public override StringBuilder Render()
        {
            var groups = (IEnumerable<IGrouping<Customer, Order>>)Data;
            var output = new StringBuilder();

            foreach (var group in groups)
            {
                Customer customer = group.Key;
                string header, footer;
                decimal total = 0;

                // Assign table header and footer
                if (customer.Id == 0)
                {
                    header = $"# Orders from unknown customers:{Environment.NewLine}";
                    footer = $"The total order value:";
                }
                else
                {
                    header = $"# Orders from {customer.Name}:{Environment.NewLine}";
                    footer = $"The total order value for customer {customer.Name}:";
                }

                output.AppendLine(header);
                foreach (var order in group)
                {
                    total += order.GetTotalPrice();
                    output.AppendLine(order.ToString());
                }
                output.AppendLine($"{footer} {total} euro");
                output.AppendLine();
                output.AppendLine(new string('=', 60));
            }
            return output;
        }
    }
}
