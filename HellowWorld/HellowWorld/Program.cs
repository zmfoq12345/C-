using System;

namespace HellowWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //실수 float 7  double 15 16 decimal 28

            Console.WriteLine("사각형의 너비를 입력하세요");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요");
            string height = Console.ReadLine();
            int result = int.Parse(width) * int.Parse(height);
            Console.WriteLine($"사각형의 넓이는 {result}", result); // 문자열 보관 Console.WriteLine($"{변수}", 변수);
        }
    }
}
