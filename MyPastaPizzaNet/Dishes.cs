using System.Collections.Generic;

namespace MyPastaPizzaNet
{
    public class Dish
    {
        public virtual string Name { get; set; }
        public decimal Price { get; set; }

        public Dish(string name, decimal price) => (Name, Price) = (name, price);

        public override string ToString()
        {
            return $"{Name} <{Price} euro> ";
        }
    }

    public class Pizza : Dish
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = "Pizza " + value;
        }
        public List<string> Ingredients { get; set; }

        public Pizza(string name, decimal price)
            : base(name, price) => Ingredients = new List<string>();

        public Pizza(string name, decimal price, List<string> ingredients)
            : base(name, price) => Ingredients = ingredients;

        public override string ToString()
        {
            string ingredients = Ingredients.Count > 0 ?
                $"(with {string.Join(", ", Ingredients)})" : "";

            return $"{Name} {ingredients} <{Price} euro>";
        }
    }

    public class Pasta : Dish
    {
        public string Description { get; set; }

        public Pasta(string name, decimal price)
            : base(name, price) { }

        public Pasta(string name, decimal price, string description)
            : base(name, price) => Description = description;

        public override string ToString()
        {
            string description = Description != "" ?
                $"(with {Description})" : "";

            return $"{Name} {description} <{Price} euro>";
        }
    }
}