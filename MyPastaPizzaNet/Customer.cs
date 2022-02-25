using System;

namespace MyPastaPizzaNet
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(string name = "Unknown")
        {
            Name = name;
        }

        public Customer(int id, string name)
        {
            Id = id; Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}