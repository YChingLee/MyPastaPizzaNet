using System.Collections.Generic;

namespace MyPastaPizzaNet
{
    public static class MockData
    {
        public static Dish PizzaMargherita = new Pizza("Margherita", 8, new List<string> { "Tomato sauce", "Mazzarella" });
        public static Dish PizzaNapoli = new Pizza("Nopoli", 10, new List<string> { "Tomato sauce", "Mazzarella", "Anchovies", "Capers", "Olives" });
        public static Dish Lasagne = new Dish("Lasagne", 15);
        public static Dish SpaghettiCarbonara = new Pasta("Spaghetti Carbonara", 13, "Bacons, Egg, Parmesan");
        public static Dish SpaghettiBolognese = new Pasta("Spaghetti Bolognese", 12, "Ground meat, Tomato sause");

        public static Drink Water = new ColdDrink(DrinkOption.Water);
        public static Drink Coke = new ColdDrink(DrinkOption.CocaCola);
        public static Drink Lemonade = new ColdDrink(DrinkOption.Lemonade);
        public static Drink Tea = new HotDrink(DrinkOption.Tea);
        public static Drink Coffee = new HotDrink(DrinkOption.Coffee);

        public static Dessert IceCream = new Dessert(DessertOption.IceCream, 3);
        public static Dessert Tiramisu = new Dessert(DessertOption.Tiramisu, 3);
        public static Dessert Cake = new Dessert(DessertOption.Cake, 2);
    }
}
