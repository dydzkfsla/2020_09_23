using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_23
{
    class MyClass
    {
        private int number=100;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public void Plus(int val = 0)
        {
            number += val;
        }

        public void Minus(int val)
        {
            number -= val;
        }

        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void PrintHello(int val)
        {
            for(int i =0; i < val; i++)
            {
                Console.WriteLine("Hello");
            }
        }
    }

    delegate void Sample(int value);

    class Delegate1
    {
        static void Main()
        {
            MyClass dle1 = new MyClass();


            //dle1.Plus(100);
            //dle1.Minus(10);
            //dle1.Add(10, 20);
            //Console.WriteLine($"{dle1.Number}");

            Sample s1 = new Sample(dle1.Plus);  //간접호출
            s1 += new Sample(dle1.Minus);
            s1(100);
            s1 -= new Sample(dle1.Minus);
            s1(100);
            Console.WriteLine(dle1.Number);

            s1 = dle1.Minus;
            s1 += dle1.Plus;
            s1 += dle1.Plus;
            s1(200);
            Console.WriteLine(dle1.Number);

            s1 += MyClass.PrintHello;
            s1(5);
            Console.WriteLine(dle1.Number);
        }
    }
}
