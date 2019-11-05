using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0903
{
    class square
    {
        static double sqaure(double a)
        {
            return Math.Pow(a, 2);
        }

        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("결과 : " + sqaure(a));
        }
    }
}
