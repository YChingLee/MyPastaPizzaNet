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

        public static Customer JanJanssen = new Customer(1, "Jan Janssen");
        public static Customer PietPeters = new Customer(2, "Piet Peters");

        public static List<Order> Orders = new List<Order>
        {
            new Order
                    {
                        Id = 1,
                        Customer = JanJanssen,
                        Choices = new List<IChoice>
                        {
                            new MainCourse(PizzaMargherita)
                            {
                                Size = Size.Large,
                                Supplements = new List<Supplement>
                                {
                                    Supplement.Cheese, Supplement.Garlic
                                }
                            },
                            Water,
                            IceCream
                        },
                        Quantity = 2
                    },
            new Order
                    {
                        Id =2,
                        Customer = PietPeters,
                        Choices = new List<IChoice>
                        {
                            new MainCourse(PizzaMargherita),
                            Water,
                            Tiramisu
                        }
                    },
            new Order
                    {
                        Id =3,
                        Customer = PietPeters,
                        Choices = new List<IChoice>
                        {
                            new MainCourse(PizzaNapoli)
                            {
                                Size = Size.Large
                            },
                            Tea,
                            IceCream
                        },
                    },
            new Order
                    {
                        Id = 4,
                        Choices = new List<IChoice>
                        {
                            new MainCourse(Lasagne)
                            {
                                Supplements = new List<Supplement>
                                {
                                    Supplement.Garlic,
                                }
                            }
                        }
                    },
            new Order
                    {
                        Id = 5,
                        Customer = JanJanssen,
                        Choices = new List<IChoice>
                        {
                            new MainCourse(SpaghettiCarbonara),
                            Coke,
                        }
                    },
            new Order
                    {
                        Id = 6,
                        Customer = PietPeters,
                        Choices = new List<IChoice>
                        {
                            new MainCourse(SpaghettiBolognese)
                            {
                                Size = Size.Large,
                                Supplements = new List<Supplement>
                                {
                                    Supplement.Cheese,
                                }
                            },
                            Cake
                        }
                    },
            new Order
                    {
                        Id = 7,
                        Customer = PietPeters,
                        Choices = new List<IChoice>
                        {
                            Coffee,
                        },
                        Quantity = 3
                    },
            new Order
                    {
                        Id = 8,
                        Customer = JanJanssen,
                        Choices = new List<IChoice>
                        {
                            Tiramisu,
                        }
                    }
        };
    }
}
