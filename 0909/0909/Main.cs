using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _0910
{
    class MainApp
    {
        static void Main()
        {
            string Name = "Hello World";
            Name.RPrint(2); // ExtendMethod 객체를 선언하지 않고 사용이 가능하다.
                            // [this string str] . [Method Name] ( [int repeat] ) ;
            return;
        }
    }
}

static class ExtendMethod // 정적 클래스 생성
{
    public static void RPrint(this string str, int repeat) // 정적 메서드
                                                           // [this string str] . [Method Name] ( [int repeat] ) ;
    {
        for (int i = 0; i < repeat; i++)
            Console.WriteLine(str);
    }
}