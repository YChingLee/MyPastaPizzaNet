using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPastaPizzaNet
{
    public class Order
    {

        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<IChoice> Choices { get; set; }
        public int Quantity { get; set; }

        private static readonly decimal discountPercentage = 0.1m;

        public Order()
        {
            Customer = new Customer();
            Choices = new List<IChoice>();
            Quantity = 1;
        }

        public decimal GetDiscount()
        {
            // Customers get a discount when they order a combo meal.
            decimal total = 0;
            bool hasMainCourse, hasDrink, hasDessert;
            hasMainCourse = hasDrink = hasDessert = false;

            foreach (var i in Choices)
            {
                total += i.GetPrice();

                if (i is MainCourse)
                    hasMainCourse = true;
                if (i is Drink)
                    hasDrink = true;
                if (i is Dessert)
                    hasDessert = true;
            }

            if (hasMainCourse && hasDrink && hasDessert)
                return total * Quantity * discountPercentage;

            return 0m;
        }

        public decimal GetTotalPrice()
        {
            var total = Choices.Sum(choice => choice.GetPrice());
            return total * Quantity - GetDiscount();
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine($"Order Nr: {Id}");
            str.AppendLine($"Customer: {Customer.Name}");
            // Sorting order items by category: First main courses, then drinks, then desserts
            Choices.Sort((a, b) => a.CompareTo(b));
            Choices.ForEach(choice => str.AppendLine(choice.ToString()));
            str.AppendLine($"Quantity: {Quantity}");

            str.AppendLine($"Sum amount of the order: {GetTotalPrice()} euro");

            return str.ToString();
        }
    }
}