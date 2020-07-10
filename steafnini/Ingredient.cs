using System;

namespace Stef
{
    public class Ingredient
    {
        private int price;
        private string name;

        public Ingredient(int Price, string Name)
        {
            price = Price;
            name = Name;
        }

        public int cost()
        {
            return price;
        }
        public string Name()
        {
            return name;
        }
    }
}