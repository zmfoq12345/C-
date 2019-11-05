using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1
{
    class Computer
    {
        string name;
        string powerOn;

        public void Boot()
        {
            Console.WriteLine("부팅합니다.");
        }
        public void Shutdown()
        {
            Console.WriteLine("전원을 종료합니다.");
        }
        public void Reset()
        {
            Console.WriteLine("재부팅합니다.");
        }
    }

    class Notebook : Computer
    {
        int touchpadSize;
        public Notebook(int size)
        {
            touchpadSize = size;
        }

        public void useTouchpad()
        {
            Console.WriteLine("터치패드를 사용함");
        }

        public int GetSize()
        {
            return touchpadSize;
        }
    }

    class Desktop:Computer
    {

    }


    class ex09
    {
        static void Main(string[] args)
        {
            Notebook ntb = new Notebook(15);
            ntb.useTouchpad();
            Console.WriteLine(ntb.GetSize()); 
            ntb.Boot();
            ntb.Shutdown();
        }
    }
}
