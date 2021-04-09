using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        public const int size = 8;
        static void Main(string[] args)
        {
            Pool[] pool = new Pool[size];

            pool[0] = new Pool(0, 0);
            pool[1] = new Pool(4, 8);
            pool[2] = new Pool(1, 3);
            pool[3] = new Pool(4, 2);
            pool[4] = new Pool(13, 1);
            pool[5] = new Pool(12, 9);
            pool[6] = new Pool(10, 5);
            pool[7] = new Pool(6, 6);

            Sort(pool);

            Console.WriteLine("\nThe maintenance person starts from (0,0).");
            for (int i = 0; i < size - 1; i++)
            {
                pool[i].Current_loc.Display();
                Console.WriteLine(pool[i].TakeRoute(pool[i + 1]));
            }
            pool[size - 1].Current_loc.Display();

            Console.ReadKey();
        }

        static void Sort(Pool[] pool)
        {
            int first_idx = 1;
            do
            {
                int idx = first_idx - 1;
                int next_idx = first_idx;
                double temp = pool[idx].FindDistance(pool[first_idx]);
                for (int i = first_idx; i < size; i++)
                {
                    if (pool[idx].FindDistance(pool[i]) < temp)
                    {
                        temp = pool[idx].FindDistance(pool[i]);
                        next_idx = i;
                    }
                }
                if (next_idx != first_idx)
                {
                    Swap(ref pool[first_idx], ref pool[next_idx]);
                }
                first_idx++;
            } while (first_idx != size - 1);
        }

        static void Swap(ref Pool a, ref Pool b)
        {
            Pool temp = a;
            a = b;
            b = temp;
        }
    }
}
