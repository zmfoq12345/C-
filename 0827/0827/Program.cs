using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0827
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randlist = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            Random rand = new Random();
            for (int i = 0; i < 9999; i++)
            {
                int r = rand.Next(10);//20 - i);
                Console.WriteLine(r);

            }
        }
    }
}