using Microsoft.VisualBasic.CompilerServices;

namespace Stef
{
    public class Cook
    {
        private string name;
        private int dishnr;
        private int busytime;

        public string getName()
        {
            return name;
        }
        public int getTime()
        {
            return busytime;
        }

        public Cook(string Name)
        {
            name = Name;
            dishnr = 0;
            busytime = 0;
           
        }

        public int assigncook(int Busytime)
        {
            if (dishnr >= 5)
            {
                
                return 100000;
            }
            
            return busytime+Busytime;

        }

        public void addtime(int time)
        {
            busytime = busytime + time;
        }
        public void incOrder()
        {
            dishnr++;
        }
}
}