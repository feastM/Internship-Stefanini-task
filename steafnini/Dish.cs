using System;

namespace Stef
{
    public class Dish
    {
        private string name;
        private string description;
        private double price;
        private int time;


        public Dish(string Name, int Time)
        {
            name = Name;
            time = Time;
        }

        public string getName()
        {
            return name;
        }

        public void  setDesc(string ing1,string ing2, string ing3)
        {
            description = ing1 + " " + ing2 + " " + ing3;
        }

        public void setPrice(int p1, int p2, int p3 )
        {
            double x = p1 + p2 + p3;
            double y = 0.2 * x;
            price = p1 + p2 + p3 + y;
        }
        
        public string getDesc()
        {
            return description;
        }
        public double getPrice()
        {
            return price;
        }
        public int getTime()
        {
            return time;
        }
        
        

}
}