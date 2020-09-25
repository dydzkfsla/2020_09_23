using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_23
{
    delegate void FindDelegate(int prime);

    class MyPrimere
    {
        public event FindDelegate FindPrime;    // 접근제한자 이벤트 델리게이트명 이벤트명

        public void CheckPrime(int MaxNum)
        {
            bool bPrime = true;
            List<int> arr = new List<int>();


            for(int i =2; i < MaxNum; i++)// 1번
            {
                bPrime = true;
                for (int p =2; p < i; p++)// 2번
                {
                    if (i % p == 0) { bPrime = false; break; }
                }
                if (bPrime)
                {
                    FindPrime(i);
                }
            }
        }
    }


    class MyPrime
    {
        static void Main()
        {
            Console.Write("소수를 구하고 싶은 수의 범위 최대값: ");
            int MaxNum = int.Parse(Console.ReadLine());

            MyPrimere pi = new MyPrimere();
            pi.FindPrime += new FindDelegate(PrintPrime);   //c#1.0
            pi.FindPrime += PrintPrime;                     //c#2.0

            pi.CheckPrime(MaxNum);
        }

        private static void PrintPrime(int prime)
        {
            Console.WriteLine("이벤트 발생:"+prime);
        }
    }
}
