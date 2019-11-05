using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 자동구현 프로퍼티
namespace Properties3
{
    class NameCard1
    {
        string name;
        string phoneNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNum
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }

    // 자동구현 프로퍼티

    class NameCard2
    {
        public string Name { get; set; }
        public string PhoneNum { get; set; }
    }

    class NameCard3
    {
        public string Name { get; set; } = "누구??";
        public string PhoneNum { get; set; } = "010-000-0000";
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameCard2 n2 = new NameCard2();
            n2.Name = "장만월";
            Console.WriteLine(n2.Name);
            Console.WriteLine(n2.PhoneNum);
            Console.WriteLine();

            NameCard3 n3 = new NameCard3();
            Console.WriteLine(n3.Name);
            Console.WriteLine(n3.PhoneNum);
            Console.WriteLine();

            NameCard1 n1 = new NameCard1()
            {
                Name = "아이유",
                PhoneNum = "010-123-4567"
            };
            Console.WriteLine(n1.Name);
            Console.WriteLine(n1.PhoneNum);
            Console.WriteLine();
        }
    }
}
