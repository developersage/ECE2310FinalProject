using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Pool
    {
        private static int count = 0;
        private int current_count;
        private Temperature current_temp;
        private Location current_loc;
        private static Random rand = new Random();

        public Pool()
        {
            count++;
            current_count = count;
            current_temp = new Temperature(rand.Next(98, 105));
            current_loc = new Location(rand);
            Console.WriteLine("New Pool has been created with a total of " +
                "{0} pool at location {1} with temperature of {2}.", count, current_loc, current_temp);
        }
        public Pool(Temperature temp, Location loc)
        {
            count++;
            current_count = count;
            current_temp = temp;
            current_loc = loc;
            Console.WriteLine("New Pool has been created with a total of " +
                "{0} pool at location {1} with temperature of {2}.", count, current_loc, current_temp);
        }
        public Pool(int x, int y)
        {
            count++;
            current_count = count;
            current_loc = new Location(x, y);
            current_temp = new Temperature(rand.Next(98, 105));
            Console.WriteLine("New Pool has been created with a total of " +
                "{0} pool at location {1} with temperature of {2}.", count, current_loc, current_temp);
        }

        public int Current_count
        {
            get => current_count;
        }
        public Temperature Current_temp
        {
            get => current_temp; set => current_temp = value;
        }
        public Location Current_loc
        {
            get => current_loc; set => current_loc = value;
        }
        public void SetRandom()
        {
            current_temp.Degree = rand.Next(98, 105);
            current_loc.X = rand.Next(0, current_loc.Size);
            current_loc.Y = rand.Next(0, current_loc.Size);
        }
        public double FindDistance(Pool b)
        {
            return Math.Sqrt(Math.Pow(Current_loc.X - b.Current_loc.X, 2) +
                Math.Pow(Current_loc.Y - b.Current_loc.Y, 2));
        }
        public string TakeRoute(Pool b)
        {
            return String.Format("The maintenance person took a route distance of {0:f2} from {1} to {2}.", FindDistance(b), ToString(), b.ToString());
        }
        public override string ToString()
        {
            return String.Format("Pool{0} with {2} at {1}", current_count, current_loc, current_temp);
        }
    }
}
