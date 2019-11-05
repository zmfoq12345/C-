using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1
{


    class ex10
    {
        static public double SumDoubleOnly(object[] ob)
        {
            double sum = 0;
            for (int i = 0; i < ob.Length; i++)
            {

                if (ob[i] is double)
                {
                    sum += (double)ob[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            double z;

            object[] objectArr = new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true };
            Console.WriteLine(SumDoubleOnly(objectArr)); // 24.89

        }
    }
}
