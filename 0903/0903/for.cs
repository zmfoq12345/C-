using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0903
{
    class @for
    {
        static void Main(string[] args)
        {
            Console.Write("얼마나 *을 반복할까요? : ");
            int n = Int32.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("0보다 큰 수를 입력하세요");
                return;
            }

            for (int i = 0; i < n; i++){
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}
