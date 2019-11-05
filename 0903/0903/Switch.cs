using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0903
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("요일을 입력하세요");
            string date = Console.ReadLine();

            switch (date)
            {
                case "월":
                    Console.WriteLine("Monday");
                    break;

                case "화":
                    Console.WriteLine("Tuesday");
                    break;
                case "수":
                    Console.WriteLine("Wednesday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                case "일":
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("요일이 아닙니다.");
                    break;
            }

        }
    }
}
