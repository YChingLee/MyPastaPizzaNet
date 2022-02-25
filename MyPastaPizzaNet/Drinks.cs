using System;

namespace MyPastaPizzaNet
{
    public enum DrinkOption
    {
        Water = 1, Lemonade = 2, CocaCola = 3, Coffee = 31, Tea = 32
    }


    public abstract class Drink : IChoice, IComparable<IChoice>
    {
        public virtual DrinkOption Name { get; set; }
        public virtual decimal Price { get; set; }

        public Drink(DrinkOption name) => Name = name;

        public virtual decimal GetPrice() => Price;

        public int CompareTo(IChoice other)
        {
            if (other is MainCourse)
                return 1;
            else if (other is Drink)
                return 0;
            else
                return -1;
        }
        public override string ToString() => $"Drink: {Name} <{Price} euro>";
    }


    public class ColdDrink : Drink
    {
        private DrinkOption name;
        public override DrinkOption Name
        {
            get => name;
            set
            {
                if (value.GetHashCode() > 30)
                    throw new Exception($"Error: {value} is not a cold drink.");
                name = value;
            }
        }

        private decimal price = 2m;
        public override decimal Price => price;

        public ColdDrink(DrinkOption name) : base(name) { }
    }


    public class HotDrink : Drink
    {

        private DrinkOption name;
        public override DrinkOption Name
        {
            get => name;
            set
            {
                if (value.GetHashCode() < 31)
                    throw new Exception($"Error: {value} is not a hot drink.");
                name = value;
            }
        }

        private decimal price = 2.5m;
        public override decimal Price => price;

        public HotDrink(DrinkOption name) : base(name) { }
    }
}