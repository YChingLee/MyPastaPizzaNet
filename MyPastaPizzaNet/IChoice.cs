using System;

namespace MyPastaPizzaNet
{
    public interface IChoice : IComparable<IChoice>
    {
        decimal GetPrice();
    }
}