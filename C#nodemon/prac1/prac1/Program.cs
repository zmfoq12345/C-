using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1
{
    class cube
    {
        int x = 1, y = 1, z = 1;
        static int countOfinstance = 0;

        public cube()
        {
            countOfinstance++;
        }

        public void Set(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int GetVolume()
        {
            return x * y * z;
        }

        public int Getins()
        {
            return countOfinstance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cube cube1 = new cube();
            cube1.Set(4, 5, 6);
            cube cube2 = new cube();
            cube2.Set(1, 2, 3);

            Console.WriteLine(cube1.GetVolume());
            Console.WriteLine(cube2.GetVolume());

            Console.WriteLine(cube2.Getins()); 
        }
    }
}
