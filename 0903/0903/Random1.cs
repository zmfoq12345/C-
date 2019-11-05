using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0903
{
    class Random1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int solution = random.Next() % 11;
            int n;
            Console.WriteLine("0부터 10까지의 숫자를 맞춰보세요");
            
            while(true)
            {
                n = Int32.Parse(Console.ReadLine());

                if (n > solution)

                    Console.WriteLine(n + "보다 작은수 입니다.");
                else if (n < solution)
                    Console.WriteLine(n + "보다 큰수 입니다.");

                else
                {
                    Console.WriteLine("오 정답!");
                    return;
                }
            }
        }

    }
}
