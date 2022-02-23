using System;

namespace MyPastaPizzaNet
{
    public enum DessertOption { Tiramisu, IceCream, Cake }
    public class Dessert : IChoice, IComparable<IChoice>
    {

        public DessertOption Name { get; set; }
        public decimal Price { get; set; }

        public Dessert(DessertOption name) => Name = name;
        public Dessert(DessertOption name, decimal price)
            : this(name) => (Name, Price) = (name, price);

        public virtual decimal GetPrice()
        {
            return Price;
        }

        public int CompareTo(IChoice other)
        {
            if (other is Dessert)
                return 0;
            else
                return 1;
        }
        public override string ToString()
        {
            return $"Dessert: {Name} <{Price} euro>";
        }
    }
}