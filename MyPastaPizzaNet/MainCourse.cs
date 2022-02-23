using System;
using System.Collections.Generic;
using System.Text;

namespace MyPastaPizzaNet
{
    public enum Size { Large, Small }
    public enum Supplement { Bread, Cheese, Garlic }

    public class MainCourse : IChoice
    {
        private readonly decimal priceLarge = 3m;
        private readonly decimal priceSupplement = 1m;

        public Dish Dish { get; set; }
        public Size Size { get; set; }
        public List<Supplement> Supplements { get; set; }

        public MainCourse(Dish dish, Size size = Size.Small)
        {
            Dish = dish;
            Size = size;
            Supplements = new List<Supplement>();
        }

        public decimal GetPrice()
        {
            decimal sizeSum = Size == Size.Large ? priceLarge : 0m;
            decimal supplementsSum = Supplements.Count * priceSupplement;
            return Dish.Price + sizeSum + supplementsSum;
        }

        public int CompareTo(IChoice other)
        {
            if (other is MainCourse)
                return 0;
            return -1;
        }

        public override string ToString()
        {
            var str = new StringBuilder("MainCourse: ");
            str.Append($"{Dish} /{Size} ");
            if (Supplements.Count > 0)
            {
                str.Append($"/Extras: {string.Join(", ", Supplements)}");
            }

            return str.ToString();
        }

    }
}